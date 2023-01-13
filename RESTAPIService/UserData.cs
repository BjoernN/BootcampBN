using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPIService
{
    public class UserData
    {
        public DateTime activated { get; set; }
        public DateTime created { get; set; }
        public string department { get; set; }
        public bool enabled { get; set; }
        public string entityType { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string lastName { get; set; }
        public string location { get; set; }
        public bool pending { get; set; }
        public object phoneNumber { get; set; }
        public object position { get; set; }
        public Profile profile { get; set; }
        public Config config { get; set; }
        public string publicEmailAddress { get; set; }
        public string status { get; set; }
        public DateTime updated { get; set; }
    }

    public class Config
    {
        public string locale { get; set; }
    }

    public class Profile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string publicEmailAddress { get; set; }
        public string location { get; set; }
        public string position { get; set; }
        public string avatar { get; set; }
        public string department { get; set; }
    }
}