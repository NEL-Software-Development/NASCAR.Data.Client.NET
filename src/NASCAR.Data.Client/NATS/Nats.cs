using NATS.Client;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace NASCAR.Data.Client.NATS
{
    /// <summary>
    /// Internal NATS client class that manages NATS connections, subscriptions, and message sending.
    /// </summary>
    internal sealed class Nats : INats
    {
        /// <summary>
        /// Indicates whether the client is currently connected to the NATS server.
        /// </summary>
        private bool isConnected;

        /// <summary>
        /// A dictionary that holds the active asynchronous subscriptions.
        /// </summary>
        private Dictionary<string, IAsyncSubscription> subscriptions = new Dictionary<string, IAsyncSubscription>();

        /// <summary>
        /// The NATS connection instance used for communication with the NATS server.
        /// </summary>
        private IConnection connection;

        /// <summary>
        /// The options used to configure the NATS connection.
        /// </summary>
        private Options options;

        /// <summary>
        /// Action delegate to handle errors that occur during NATS operations.
        /// </summary>
        private Action<Exception> errorHandler;

        /// <summary>
        /// Action delegate to handle changes in the connection status.
        /// </summary>
        private Action<ConnectionStatus> connectionHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="NatsClient"/> class with the specified URL, error handler, and connection handler.
        /// </summary>
        /// <param name="url">The NATS server URL.</param>
        /// <param name="errorHandler">An action to handle exceptions.</param>
        /// <param name="connectionHandler">An action to handle connection status changes.</param>
        public Nats(string url, Action<Exception> errorHandler, Action<ConnectionStatus> connectionHandler)
        {
            options = ConnectionFactory.GetDefaultOptions();
            options.Url = url;
            this.errorHandler = errorHandler;
            this.connectionHandler = connectionHandler;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatsClient"/> class with the specified URL, authentication details, error handler, and connection handler.
        /// </summary>
        /// <param name="url">The NATS server URL.</param>
        /// <param name="cert_path">The path to the certificate file for authentication.</param>
        /// <param name="cert_password">The password for the certificate file.</param>
        /// <param name="creds_path">The path to the credentials file for authentication.</param>
        /// <param name="errorHandler">An action to handle exceptions.</param>
        /// <param name="connectionHandler">An action to handle connection status changes.</param>
        public Nats(string url, string cert_path, string cert_password, string creds_path, Action<Exception> errorHandler, Action<ConnectionStatus> connectionHandler)
        {
            options = auth(cert_path, cert_password, creds_path);
            options.Url = url;
            this.errorHandler = errorHandler;
            this.connectionHandler = connectionHandler;
        }

        /// <summary>
        /// Configures authentication options using a certificate and credentials.
        /// </summary>
        /// <param name="cert_path">The path to the certificate file for authentication.</param>
        /// <param name="cert_password">The password for the certificate file.</param>
        /// <param name="creds_path">The path to the credentials file for authentication.</param>
        /// <returns>The configured <see cref="Options"/> for authentication.</returns>
        private Options auth(string cert_path, string cert_password, string creds_path)
        {
            var options = ConnectionFactory.GetDefaultOptions();
            options.Secure = true;
            var cert = new X509Certificate2(cert_path, cert_password);
            options.TLSRemoteCertificationValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            options.AddCertificate(cert);
            options.SetUserCredentials(creds_path);
            return options;
        }

        /// <summary>
        /// Establishes a connection to the NATS server.
        /// </summary>
        /// <returns>True if the connection was successful; otherwise, false.</returns>
        public bool Connect()
        {
            try
            {
                connection = new ConnectionFactory().CreateConnection(options);
                connectionHandler.Invoke(ConnectionStatus.Connected);
                isConnected = true;
                return true;
            }
            catch (Exception err)
            {
                errorHandler.Invoke(err);
                connectionHandler.Invoke(ConnectionStatus.Disconnected);
            }
            return false;
        }

        /// <summary>
        /// Disconnects from the NATS server and cleans up the connection.
        /// </summary>
        /// <returns>True if the disconnection was successful; otherwise, false.</returns>
        public bool Disconnect()
        {
            try
            {
                connection.Drain();
                connection.Close();
                isConnected = false;
                return true;
            }
            catch (Exception err)
            {
                errorHandler.Invoke(err);
            }
            return false;
        }

        /// <summary>
        /// Subscribes to a specific NATS endpoint and processes incoming messages using the provided handler.
        /// </summary>
        /// <typeparam name="T">The type of the message data.</typeparam>
        /// <param name="endpoint">The NATS endpoint to subscribe to.</param>
        /// <param name="handler">The handler to process incoming messages.</param>
        /// <returns>True if the subscription was successful; otherwise, false.</returns>
        public bool Subscribe<T>(string endpoint, Action<T> handler)
        {
            if (isConnected)
            {
                try
                {
                    var subscription = connection.SubscribeAsync(endpoint);
                    subscription.MessageHandler += (sender, message) =>
                    {
                        var parsed = messageHandler<T>(message);
                        if (parsed != null)
                        {
                            handler(parsed);
                        }
                    };

                    subscription.Start();
                    subscriptions.Add(endpoint, subscription);
                    return true;
                }
                catch (Exception err)
                {
                    errorHandler.Invoke(err);
                }
            }
            return false;
        }

        /// <summary>
        /// Unsubscribes from a specific NATS endpoint.
        /// </summary>
        /// <param name="endpoint">The NATS endpoint to unsubscribe from.</param>
        /// <returns>True if the unsubscription was successful; otherwise, false.</returns>
        public bool Unsubscribe(string endpoint)
        {
            if (isConnected && subscriptions.ContainsKey(endpoint))
            {
                try
                {
                    var subscription = subscriptions[endpoint];
                    subscription.Unsubscribe();
                    subscriptions.Remove(endpoint);
                    return true;
                }
                catch (Exception err)
                {
                    errorHandler.Invoke(err);
                }
            }
            return false;
        }

        /// <summary>
        /// Sends a message to a specific NATS endpoint.
        /// </summary>
        /// <typeparam name="T">The type of the message data to be sent.</typeparam>
        /// <param name="endpoint">The NATS endpoint to send the message to.</param>
        /// <param name="data">The message data to send.</param>
        /// <returns>True if the message was sent successfully; otherwise, false.</returns>
        public bool Send<T>(string endpoint, T data)
        {
            if (isConnected)
            {
                try
                {
                    var ser = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(data));
                    connection.Publish(endpoint, ser);
                    return true;
                }
                catch (Exception err)
                {
                    errorHandler.Invoke(err);
                }
            }
            return false;
        }

        /// <summary>
        /// Handles incoming messages, deserializing them into the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the message data.</typeparam>
        /// <param name="args">The message arguments containing the data.</param>
        /// <returns>The deserialized message data of type <typeparamref name="T"/>.</returns>
        private T messageHandler<T>(MsgHandlerEventArgs args)
        {
            try
            {
                var val = Encoding.UTF8.GetString(args.Message.Data);
                return JsonSerializer.Deserialize<T>(val);
            }
            catch (Exception err)
            {
                errorHandler.Invoke(err);
            }
            return default;
        }
    }

}
