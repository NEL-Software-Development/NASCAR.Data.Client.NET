using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS
{
    /// <summary>
    /// Represents the authentication details required for connecting to a NATS server with certificate-based authentication.
    /// </summary>
    public class NatsAuthentication
    {
        /// <summary>
        /// Gets or sets the path to the certificate file used for authentication.
        /// </summary>
        public string CertificatePath { get; set; }

        /// <summary>
        /// Gets or sets the password for the certificate file.
        /// </summary>
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Gets or sets the path to the credentials file used for authentication.
        /// </summary>
        public string CredentialsPath { get; set; }
    }

}
