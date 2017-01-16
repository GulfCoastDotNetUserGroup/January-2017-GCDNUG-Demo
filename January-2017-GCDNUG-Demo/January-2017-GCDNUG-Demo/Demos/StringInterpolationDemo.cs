using System;
using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Misc;
// Static using
using static System.Reflection.MethodBase;


namespace January_2017_GCDNUG_Demo.Demos
{
    public class StringInterpolationDemo : AbstractDemo
    {
        #region Constructors

        public StringInterpolationDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.Append($"{GreetingWithConcatination()}{DemoConstants.DoubleSpace}");

            sb.Append($"{GreetingWithStringFormat()}{DemoConstants.DoubleSpace}");

            sb.Append(GreetingWithStringInterpolation());

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // With '+' operator
        private string GreetingWithConcatination()
        {
            return GetCurrentMethod().MethodSignature() + Environment.NewLine + DemoConstants.Hello + Input + "!";
        }

        // With string.Format()
        private string GreetingWithStringFormat()
        {
            return string.Format("{0}{1}{2}{3}!",
                GetCurrentMethod().MethodSignature(), Environment.NewLine, DemoConstants.Hello,  Input);
        }

        // With string interpolation
        private string GreetingWithStringInterpolation()
        {
            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{DemoConstants.Hello}{Input}!";
        }

        #endregion Private Methods
    }
}
