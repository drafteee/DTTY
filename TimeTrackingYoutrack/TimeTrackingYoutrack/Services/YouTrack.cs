using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingYoutrack.Services
{
    public class YouTrack
    {
        
        public async Task<UserInfo> Login(string token)
        {
            UserInfo userInfo = null;
            using (var client = new HttpClient())
            {


                var req = new HttpRequestMessage(HttpMethod.Get, "http://sa-yt.ipps.by/api/users/me?fields=$type,banned,email,fullName,guest,id,login,ringId");
                req.Headers.Add("Accept", "application/json");
                req.Headers.Add("Authorization", $"Bearer {token}");
                req.Headers.Add("Cache-Control", "no-cache");

                HttpResponseMessage response = await client.SendAsync(req);
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    userInfo = JsonConvert.DeserializeObject<UserInfo>(result);

                }
            }

            return userInfo;
        }

        public Auth LoadJson()
        {
            using (StreamReader r = new StreamReader("./Auth.json"))
            {
                string json = r.ReadToEnd();
                Auth item = JsonConvert.DeserializeObject<Auth>(json);
                return item;
            }
        }

        public class Auth
        {
            public string Token;
        }
    }
}
