using Microsoft.Extensions.Logging;
using NASCAR.Data.Client.NATS.DataPoints;
using System;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS
{
    /// <summary>
    /// Represents a NATS client that provides methods to connect, disconnect, subscribe, unsubscribe, and send messages using NATS.
    /// </summary>
    public class NatsClient : INats
    {
        /// <summary>
        /// True if pointed at production, False if pointed at integration. Default = True.</param>
        /// </summary>
        private bool isProduction;

        /// <summary>
        /// The internal NATS client instance that performs the actual NATS operations.
        /// </summary>
        private INats nats;

        /// <summary>
        /// Initializes a new instance of the <see cref="NatsClient"/> class using a NATS URL and authentication details.
        /// </summary>
        /// <param name="url">The NATS server URL.</param>
        /// <param name="auth">The <see cref="NatsAuthentication"/> object containing the authentication details.</param>
        public NatsClient(string url, NatsAuthentication auth, bool isProduction = true)
        {
            nats = new NatsBuilder(url)
                .WithAuth(auth)
                .WithErrorHandler(OnError)
                .WithConnectionHandler(OnConnectionStatusChanged)
                .Build();
            this.isProduction = isProduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatsClient"/> class using a NATS URL, certificate path, certificate password, and credentials path.
        /// </summary>
        /// <param name="url">The NATS server URL.</param>
        /// <param name="cert_path">The path to the certificate file used for authentication.</param>
        /// <param name="cert_pass">The password for the certificate file.</param>
        /// <param name="creds_path">The path to the credentials file used for authentication.</param>
        public NatsClient(string url, string cert_path, string cert_pass, string creds_path, bool isProduction = true)
        {
            nats = new NatsBuilder(url)
                .WithAuth(cert_path, cert_pass, creds_path)
                .WithErrorHandler(OnError)
                .WithConnectionHandler(OnConnectionStatusChanged)
                .Build();
            this.isProduction = isProduction;
        }

        /// <summary>
        /// Logs an error that occurs in the NATS client.
        /// </summary>
        /// <param name="err">The exception that occurred.</param>
        private void OnError(Exception err)
        {
            Console.WriteLine("NATS error: " + err.Message);
        }

        /// <summary>
        /// Handles changes in the NATS connection status, including automatic reconnection on disconnect.
        /// </summary>
        /// <param name="status">The current <see cref="ConnectionStatus"/> of the NATS client.</param>
        private void OnConnectionStatusChanged(ConnectionStatus status)
        {
            if (status == ConnectionStatus.Disconnected)
            {
                Console.WriteLine("Disconnected from NATS... reconnecting...");
                Task.Delay(1000).Wait();
                nats.Connect();
            }
        }

        /// <summary>
        /// Connects to the NATS server.
        /// </summary>
        /// <returns>True if the connection is successful; otherwise, false.</returns>
        public bool Connect() => nats.Connect();

        /// <summary>
        /// Disconnects from the NATS server.
        /// </summary>
        /// <returns>True if the disconnection is successful; otherwise, false.</returns>
        public bool Disconnect() => nats.Disconnect();

        /// <summary>
        /// Subscribes to a NATS endpoint and processes incoming messages using the provided handler.
        /// </summary>
        /// <typeparam name="T">The type of the message data.</typeparam>
        /// <param name="endpoint">The NATS endpoint to subscribe to.</param>
        /// <param name="messageHandler">The handler to process incoming messages.</param>
        /// <returns>True if the subscription is successful; otherwise, false.</returns>
        public bool Subscribe<T>(string endpoint, Action<T> messageHandler) => nats.Subscribe(endpoint, messageHandler);

        /// <summary>
        /// Subscribes to a NATS <see cref="DataPoint"/> and processes incoming messages using the provided handler.
        /// </summary>
        /// <typeparam name="T">The type of the message data.</typeparam>
        /// <param name="dataPoint">The NATS <see cref="DataPoint"/> to subscribe to.</param>
        /// <param name="messageHandler">The handler to process incoming messages.</param>
        /// <returns>True if the subscription is successful; otherwise, false.</returns>
        public bool Subscribe<T>(DataPoint dataPoint, Action<T> messageHandler)
        {
            return nats.Subscribe(dataPoint.GetID(isProduction), messageHandler);
        }

        /// <summary>
        /// Unsubscribes from a specific NATS endpoint.
        /// </summary>
        /// <param name="endpoint">The NATS endpoint to unsubscribe from.</param>
        /// <returns>True if the unsubscription is successful; otherwise, false.</returns>
        public bool Unsubscribe(string endpoint) => nats.Unsubscribe(endpoint);

        /// <summary>
        /// Unsubscribes from a specific NATS <see cref="DataPoint"/>.
        /// </summary>
        /// <param name="dataPoint">The NATS <see cref="DataPoint"/> to unsubscribe from.</param>
        /// <returns>True if the unsubscription is successful; otherwise, false.</returns>
        public bool Unsubscribe(DataPoint dataPoint)
        {
            return nats.Unsubscribe(dataPoint.GetID(isProduction));
        }

        /// <summary>
        /// Sends a message to a specific NATS endpoint.
        /// </summary>
        /// <typeparam name="T">The type of the message data to be sent.</typeparam>
        /// <param name="endpoint">The NATS endpoint to send the message to.</param>
        /// <param name="data">The message data to send.</param>
        /// <returns>True if the message is sent successfully; otherwise, false.</returns>
        public bool Send<T>(string endpoint, T data) => nats.Send(endpoint, data);

        /// <summary>
        /// Sends a message to a specific NATS <see cref="DataPoint"/>.
        /// </summary>
        /// <typeparam name="T">The type of the message data to be sent.</typeparam>
        /// <param name="dataPoint">The NATS <see cref="DataPoint"/> to send the message to.</param>
        /// <param name="data">The message data to send.</param>
        /// <returns>True if the message is sent successfully; otherwise, false.</returns>
        public bool Send<T>(DataPoint dataPoint, T data) 
        { 
            return nats.Send(dataPoint.GetID(isProduction), data); 
        }
    }

}
