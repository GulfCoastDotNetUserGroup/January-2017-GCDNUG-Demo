using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_2017_GCDNUG_Demo.Misc
{
    public class UserInfo
    {
        public string UserFirstName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserLastName { get; set; }

        public UserInfo(string fn, string mn, string ln)
        {
            UserFirstName = fn;
            UserMiddleName = mn;
            UserLastName = ln;
        }
    }
}
