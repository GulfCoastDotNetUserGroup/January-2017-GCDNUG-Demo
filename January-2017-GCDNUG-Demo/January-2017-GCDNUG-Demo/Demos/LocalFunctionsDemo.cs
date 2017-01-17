using System;
using System.Text;
using January_2017_GCDNUG_Demo.Misc;
using static System.Environment;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class LocalFunctionsDemo : AbstractDemo
    {
        #region Properties
        #endregion Properties

        #region Constructors

        public LocalFunctionsDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.AppendLine("ReverseString(Input)");
            sb.AppendLine($"{ReverseString(Input)}{NewLine}");
            sb.AppendLine("ReverseString(Input, true)");
            sb.AppendLine(ReverseString(Input, true));

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private static string ReverseString(string input, bool toUpper = false)
        {
            if (string.IsNullOrEmpty(input)) throw new DotNetUserGroupException();

            return toUpper 
                ? Reverse(input).reversedToUpper
                : Reverse(input).reversed;

            (string reversed, string reversedToUpper) Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return (new string(charArray), new string(charArray).ToUpper());
            } 
        }

        #endregion Private Methods
    }
}
