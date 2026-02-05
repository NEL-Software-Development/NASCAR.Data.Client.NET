using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;
using NASCAR.Data.Client.Utility;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.Example
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Using a token manager
            TokenManager _tokenManager = new TokenManager();

            if(_tokenManager.GetAccessToken().IsExpired())
            {
                AccountApi _account = new AccountApi();
                TokenResponse tokenResponse = _account.AccountRefreshTokenGet(_tokenManager.GetRefreshToken());
                _tokenManager.StoreRefreshToken(tokenResponse);
            }

            var config = Configuration.Default;

            config.BasePath = "https://localhost:54561";

            var token = _tokenManager.GetAccessToken();
            config.AccessToken = token;
            config.AddApiKey("api_key", token);
            config.AddApiKeyPrefix("api_key", "Bearer");


            //Using Api's
            CompanyApi _companies = new CompanyApi(config);
            DriverApi _drivers = new DriverApi(config);

            Collection<Company> companyResult = _companies.CompanySearchGet("NASCAR");
            Collection<Driver> driverResult = _drivers.DriverSeasonGet(season: 2025, seriesId: 1);

            Console.WriteLine("Found " + companyResult.Count() + " companies.");
            Console.WriteLine("Found " + driverResult.Count() + " drivers.");

            Console.WriteLine("Press ENTER to continue to subscription example.");
            Console.ReadLine();

            //Subscription Example
            SubscriptionManager.Initialize(config);
            SubscriptionManager.Add("Drivers");
            await SubscriptionManager.Start();
        }
    }
}
