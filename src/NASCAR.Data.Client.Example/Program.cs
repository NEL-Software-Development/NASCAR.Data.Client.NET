using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace NASCAR.Data.Client.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Configuration _config = new Configuration()
            {
                AccessToken = "..."
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
