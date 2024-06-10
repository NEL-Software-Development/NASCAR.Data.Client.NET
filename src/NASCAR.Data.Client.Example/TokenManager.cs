using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using NASCAR.Data.Client.Model;
using Newtonsoft.Json.Linq;

namespace NASCAR.Data.Client.Example
{
    public class TokenManager
    {
        private readonly string _appSettingsFile;

        public TokenManager()
        {
            _appSettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
        }

        public void StoreRefreshToken(TokenResponse tokenResponse)
        {
            var json = File.ReadAllText(_appSettingsFile);
            var jsonObj = JObject.Parse(json);
            var refreshTokenSettings = jsonObj["TokenSettings"];

            refreshTokenSettings["RefreshToken"] = tokenResponse.RefreshToken;
            refreshTokenSettings["RefreshToken"] = tokenResponse.AccessToken;

            File.WriteAllText(_appSettingsFile, jsonObj.ToString());
        }

        public string GetRefreshToken()
        {
            var json = File.ReadAllText(_appSettingsFile);
            var jsonObj = JObject.Parse(json);

            var token = jsonObj["TokenSettings"]["RefreshToken"].ToString();

            return token;
        }

        public string GetAccessToken()
        {
            var json = File.ReadAllText(_appSettingsFile);
            var jsonObj = JObject.Parse(json);

            var token = jsonObj["TokenSettings"]["AccessToken"].ToString();

            return token;
        }
    }
}
