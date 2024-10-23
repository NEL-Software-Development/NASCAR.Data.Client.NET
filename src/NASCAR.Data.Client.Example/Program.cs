using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;
using NASCAR.Data.Client.Utility;
using NASCAR.Data.Client.NATS;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using NASCAR.Data.Client.NATS.Models.OpticalTrackingData;

namespace NASCAR.Data.Client.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--> NASCAR Data API <--//
            TokenManager _tokenManager = new TokenManager();

            if (_tokenManager.GetAccessToken().IsExpired())
            {
                AccountApi _account = new AccountApi();
                TokenResponse tokenResponse = _account.AccountRefreshTokenGet(_tokenManager.GetRefreshToken());
                _tokenManager.StoreRefreshToken(tokenResponse);
            }

            Configuration _config = new Configuration()
            {
                AccessToken = _tokenManager.GetAccessToken()
            };

            CompanyApi _companies = new CompanyApi(_config);
            DriverApi _drivers = new DriverApi(_config);

            Collection<Company> companyResult = _companies.CompanySearchGet("NASCAR");
            Collection<Driver> driverResult = _drivers.DriverSeasonGet(season: 2023, seriesId: 1);

            Console.WriteLine("Found " + companyResult.Count() + " companies.");
            Console.WriteLine("Found " + driverResult.Count() + " drivers.");
            Console.ReadLine();


            //--> NASCAR NATS Connector <--//
            NatsAuthentication auth = new NatsAuthentication()
            {
                CertificatePath = "<PATH_TO_CERT_FILE>",
                CertificatePassword = "<CERT_PASSWORD>",
                CredentialsPath = "<PATH_TO_CREDENTIALS_FILE>"
            };
            NatsClient _natsClient = new NatsClient("<NATS_URL>", auth);
            _natsClient.Connect();
            _natsClient.Subscribe<LocationData>(NATS.DataPoints.DataPoint.LowLatency, (val) =>
            {
                Console.WriteLine(val.Time);
            });

            _natsClient.Unsubscribe(NATS.DataPoints.DataPoint.LowLatency);

            Console.ReadLine();
            _natsClient.Disconnect();
        }
    }
}
