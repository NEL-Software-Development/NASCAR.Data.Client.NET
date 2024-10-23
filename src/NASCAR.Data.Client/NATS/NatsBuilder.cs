using System;

namespace NASCAR.Data.Client.NATS
{
    /// <summary>
    /// Builder class for configuring and creating an instance of NATS client with optional authentication and handlers.
    /// </summary>
    public class NatsBuilder
    {
        /// <summary>
        /// The URL of the NATS server.
        /// </summary>
        private readonly string url;

        /// <summary>
        /// Indicates whether authentication is enabled.
        /// </summary>
        private bool withAuth;

        /// <summary>
        /// The path to the certificate file for authentication.
        /// </summary>
        private string cert_path;

        /// <summary>
        /// The password for the certificate file used in authentication.
        /// </summary>
        private string cert_pass;

        /// <summary>
        /// The path to the credentials file for authentication.
        /// </summary>
        private string creds_path;

        /// <summary>
        /// The error handler action that will be invoked when an exception occurs.
        /// </summary>
        private Action<Exception> errorHandler;

        /// <summary>
        /// The connection handler action that will be invoked when the NATS connection status changes.
        /// </summary>
        private Action<ConnectionStatus> connectionHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="NatsBuilder"/> class with a specified NATS server URL.
        /// </summary>
        /// <param name="url">The URL of the NATS server.</param>
        /// <exception cref="ArgumentNullException">Thrown if the <paramref name="url"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown if the <paramref name="url"/> is an empty string.</exception>
        public NatsBuilder(string url)
        {
            if (url == null) throw new ArgumentNullException("Nats url cannot be null");
            if (url.Length == 0) throw new ArgumentException("Nats url cannot be empty");
            this.url = url;
        }

        /// <summary>
        /// Enables authentication by specifying certificate path, certificate password, and credentials path.
        /// </summary>
        /// <param name="cert_path">The path to the certificate file.</param>
        /// <param name="cert_pass">The password for the certificate.</param>
        /// <param name="creds_path">The path to the credentials file.</param>
        /// <returns>The current <see cref="NatsBuilder"/> instance with authentication configured.</returns>
        public NatsBuilder WithAuth(string cert_path, string cert_pass, string creds_path)
        {
            withAuth = true;
            this.cert_path = cert_path;
            this.cert_pass = cert_pass;
            this.creds_path = creds_path;
            return this;
        }

        /// <summary>
        /// Enables authentication by specifying an instance of <see cref="NatsAuthentication"/> containing certificate and credentials information.
        /// </summary>
        /// <param name="auth">An instance of <see cref="NatsAuthentication"/> that holds the certificate path, certificate password, and credentials path.</param>
        /// <returns>The current <see cref="NatsBuilder"/> instance with authentication configured.</returns>
        public NatsBuilder WithAuth(NatsAuthentication auth)
        {
            withAuth = true;
            this.cert_path = auth.CertificatePath;
            this.cert_pass = auth.CertificatePassword;
            this.creds_path = auth.CredentialsPath;
            return this;
        }


        /// <summary>
        /// Configures an error handler for handling exceptions during NATS operations.
        /// </summary>
        /// <param name="errorHandler">An action that will be invoked when an exception occurs.</param>
        /// <returns>The current <see cref="NatsBuilder"/> instance with the error handler configured.</returns>
        public NatsBuilder WithErrorHandler(Action<Exception> errorHandler)
        {
            this.errorHandler = errorHandler;
            return this;
        }

        /// <summary>
        /// Configures a connection handler for monitoring NATS connection status.
        /// </summary>
        /// <param name="connectionHandler">An action that will be invoked when the connection status changes.</param>
        /// <returns>The current <see cref="NatsBuilder"/> instance with the connection handler configured.</returns>
        public NatsBuilder WithConnectionHandler(Action<ConnectionStatus> connectionHandler)
        {
            this.connectionHandler = connectionHandler;
            return this;
        }

        /// <summary>
        /// Builds and returns an instance of <see cref="INats"/> based on the current configuration.
        /// </summary>
        /// <returns>An instance of <see cref="INats"/> with the specified configuration.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if either the <see cref="errorHandler"/> or <see cref="connectionHandler"/> is null,
        /// or if the NATS URL is null or empty.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if authentication is enabled but the certificate path, certificate password, or credentials path is null or empty.
        /// </exception>
        public INats Build()
        {
            if (errorHandler == null || connectionHandler == null) throw new ArgumentNullException("You must include an error and connection handler");
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException("Nats url cannot be null");

            if (withAuth)
            {
                if (string.IsNullOrEmpty(cert_path) || string.IsNullOrEmpty(cert_pass) || string.IsNullOrEmpty(creds_path)) throw new ArgumentNullException("can't use authenticated nats without cert path, cert pass, and creds path");

                return new Nats(url, cert_path, cert_pass, creds_path, errorHandler, connectionHandler);
            }
            return new Nats(url, errorHandler, connectionHandler);
        }
    }

}
