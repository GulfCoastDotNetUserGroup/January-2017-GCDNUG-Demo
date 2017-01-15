using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;
// Static using
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class StringInterpolationDemo : IMessageBuilder
    {
        #region Properties

        public string Name { get; set; }

        #endregion Properties

        #region Constructors

        public StringInterpolationDemo(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Public Methods

        public string GetMessage()
        {
            var sb = new StringBuilder();
            sb.Append(GreetingWithConcatination());
            sb.Append(DemoConstants.DoubleSpace);
            sb.Append(GreetingWithStringFormat());
            sb.Append(DemoConstants.DoubleSpace);
            sb.Append(GreetingWithStringInterpolation());

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // With '+' operator
        private string GreetingWithConcatination()
        {
            return DemoConstants.Hello + Name + "!  "  + GetCurrentMethod().MethodSignature();
        }

        // With string.Format()
        private string GreetingWithStringFormat()
        {
            return string.Format("{0}{1}!  {2}", DemoConstants.Hello,  Name, GetCurrentMethod().MethodSignature());
        }

        // With string interpolation
        private string GreetingWithStringInterpolation()
        {
            return $"{DemoConstants.Hello}{Name}!  {GetCurrentMethod().MethodSignature()}";
        }

        #endregion Private Methods
    }
}
