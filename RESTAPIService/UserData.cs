using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPIService
{
    public class UserData
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public Config config { get; set; }
    }

    public class Config
    {
        public string locale { get; set; }
    }
}