using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPIService
{
    public class RESTAPIService
    {
        private string _baseurl = "https://backend.staffbase.com/api";

        public UserData GetData(string AccessToken, string UserId)
        {
            var ret = new UserData();

            var client = new WebClient();
            client.Headers.Add("Authorization", $"Basic {AccessToken}");
            client.Headers.Add("content-type", "application/json;charset=utf-8");

            var url = $"{_baseurl}/users/{UserId}";

            var data = client.DownloadString(url);

            ret = JsonConvert.DeserializeObject<UserData>(data);

            return ret;
        }
    }
}
