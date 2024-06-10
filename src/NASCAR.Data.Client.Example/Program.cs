using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;
using NASCAR.Data.Client.Utility;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace NASCAR.Data.Client.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TokenManager _tokenManager = new TokenManager();

            if(_tokenManager.GetAccessToken().IsExpired())
            {
                AccountApi _account = new AccountApi();
                TokenResponse tokenResponse = _account.RefreshToken(_tokenManager.GetRefreshToken());
                _tokenManager.StoreRefreshToken(tokenResponse);
            }

            Configuration _config = new Configuration()
            {
                AccessToken = _tokenManager.GetAccessToken()
            };

            CompanyApi _companies = new CompanyApi(_config);
            DriverApi _drivers = new DriverApi(_config);

            Collection<Company> companyResult = _companies.FindCompany("NASCAR");
            Collection<Driver> driverResult = _drivers.BySeason(season: 2023, seriesId: 1);


            Console.WriteLine("Found " + companyResult.Count() + " companies.");
            Console.WriteLine("Found " + driverResult.Count() + " drivers.");
            Console.ReadLine();
        }
    }
}
