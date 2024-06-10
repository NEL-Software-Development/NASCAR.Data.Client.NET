using NASCAR.Data.Client.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace NASCAR.Data.Client.Utility
{
    public static class Extensions
    {

        public static bool IsExpired(this string token)
        {
            return token.GetExpiration() < DateTimeOffset.UtcNow;
        }

        private static DateTimeOffset GetExpiration(this string token) 
        {
            string[] parts = token.Split('.');
            if (parts.Length != 3)
            {
                throw new ArgumentException("Invalid JWT token format.");
            }

            string payload = parts[1];

            string decodedToken = payload.Base64UrlDecode();

            JObject tokenJson = JObject.Parse(decodedToken);
            long exp = tokenJson.Value<long>("exp");

            DateTimeOffset expirationTime = exp.UnixTimeStampToDateTime();
            return expirationTime;
        }

        private static string Base64UrlDecode(this string input)
        {
            string output = input;
            output = output.Replace('-', '+');
            output = output.Replace('_', '/');

            switch (output.Length % 4)
            {
                case 0: break;
                case 2: output += "=="; break;
                case 3: output += "="; break; 
                default: throw new ArgumentException("Illegal base64url string!", input);
            }

            var converted = Convert.FromBase64String(output);
            return Encoding.UTF8.GetString(converted);
        }

        private static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTimeStamp);
        }
    }
}
