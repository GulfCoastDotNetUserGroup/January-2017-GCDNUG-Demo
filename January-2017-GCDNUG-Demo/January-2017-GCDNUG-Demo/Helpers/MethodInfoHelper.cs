using System.Linq;
using System.Reflection;

namespace January_2017_GCDNUG_Demo.Helpers
{
    public static class MethodInfoHelper
    {
        public static string MethodSignature(this MethodBase mi)
        {
            string[] param = mi.GetParameters()
                          .Select(p => $"{p.ParameterType.Name} {p.Name}")
                          .ToArray();

            return $"{mi.Name}({string.Join(",", param)})";
        }
    }
}
