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
                AccessToken = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJodHRwczovL25hc2Nhci5jb20vYXBpIiwiaXNzIjoiaHR0cHM6Ly9uYXNjYXIuY29tLyIsImp0aSI6ImRmZWUyYWI2MGJiNjQ2NTNiZTQ2YTRhZWFhMzcxODcxIiwic3ViIjo2ODgwNCwiaWF0IjoiMTcxNzYyMjgwNiIsIm5iZiI6IjE3MTc2MjI4MDYiLCJleHAiOiIxNzE4MjI3NjA2IiwiZ2l2ZW5fbmFtZSI6IlRpbSIsImZhbWlseV9uYW1lIjoiUmVuaW5nZXIiLCJwcm9maWxlIjoiaHR0cHM6Ly9lbXAubmFzY2FyLmNvbS9lbnRpdGllcy9jb250YWN0LzY4ODA0IiwiaHR0cDovL25hc2Nhci9hdXRoMGlkIjoid2FhZHxXaHFqU2toMlRHNnp6ZHppTTAtYnI4b1Q0NVFLRDhZTXdYNGZLdnZITktBIiwiaHR0cDovL25hc2Nhci9hcHBuYW1lIjoiQ2xpZW50U0RLVGVzdCIsImh0dHA6Ly9uYXNjYXIvaXN0ZXN0YXBwIjoiRmFsc2UiLCJodHRwOi8vbmFzY2FyL2NvbXBhbnlfaWQiOjEsImVtYWlsIjoidHJlbmluZ2VyQG5hc2Nhci5jb20iLCJuYW1lIjoiVGltIFJlbmluZ2VyIiwidXBkYXRlZF9hdCI6IjE2NTUyODkwODIiLCJodHRwOi8vbmFzY2FyL3JvbGVzIjpbIk5BU0NBUl9BUElfUm9sZV9JbnRlcm5hbCJdfQ.mzUeq620vDzaaRrSnNm_JrRCLgSQF8C4pC5t-_HKGVCOtzHIJVrBPQkWHRslUJEr9ExcRtwVUcQ2rJscvpWuHA"
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
