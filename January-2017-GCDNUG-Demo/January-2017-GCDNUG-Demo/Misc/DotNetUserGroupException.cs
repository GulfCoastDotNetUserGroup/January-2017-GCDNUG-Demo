using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static January_2017_GCDNUG_Demo.Misc.Enums;

namespace January_2017_GCDNUG_Demo.Misc
{
    [Serializable]
    public class DotNetUserGroupException : Exception
    {
        public ExceptionPanicLevelEnum PanicLevel { get; set; }
    }
}
