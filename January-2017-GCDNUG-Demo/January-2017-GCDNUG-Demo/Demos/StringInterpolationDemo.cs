using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
// Static using
using static System.Reflection.MethodBase;
using static System.Environment;


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

            sb.AppendLine($"{GreetingWithConcatination()}{NewLine}");

            sb.AppendLine($"{GreetingWithStringFormat()}{NewLine}");

            sb.Append(GreetingWithStringInterpolation());

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // With '+' operator
        private string GreetingWithConcatination()
        {
            return GetCurrentMethod().MethodSignature() + NewLine + "Hello, " + Input + "!";
        }

        // With string.Format()
        private string GreetingWithStringFormat()
        {
            return string.Format("{0}{1}Hello, {2}!",
                GetCurrentMethod().MethodSignature(), NewLine, Input);
        }

        // With string interpolation
        private string GreetingWithStringInterpolation()
        {
            return $"{GetCurrentMethod().MethodSignature()}{NewLine}Hello, {Input}!";
        }

        #endregion Private Methods
    }
}
