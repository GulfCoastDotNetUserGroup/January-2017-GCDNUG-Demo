using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Misc;
using System;
using System.Text;
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class OutVariablesDemo : AbstractDemo
    {
        #region Constructors

        public OutVariablesDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.Append($"OLD OUT VARIABLES{DemoConstants.DoubleSpace}");
            sb.Append($"{GetMessageWithOldOutVariables()}{DemoConstants.DoubleSpace}{Environment.NewLine}");
            sb.Append($"NEW OUT VARIABLES{DemoConstants.DoubleSpace}");
            sb.Append(GetMessageWithNewOutVariables());

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private string GetMessageWithOldOutVariables()
        {
            string firstName, middleName, lastName;
            ProcessUserInput(Input.Split(' '), out firstName, out middleName, out lastName);

            UserInfo userInfo = new UserInfo(firstName, middleName, lastName);

            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{BuildMessage(userInfo)}";
        }

        private string GetMessageWithNewOutVariables()
        {
            ProcessUserInput(Input.Split(' '), out string firstName, out string middleName, out string lastName);

            UserInfo userInfo = new UserInfo(firstName, middleName, lastName);

            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{BuildMessage(userInfo)}";
        }

        private string BuildMessage(UserInfo userInfo)
        {
            var sb = new StringBuilder();

            sb.Append($"First Name: {userInfo.UserFirstName}{Environment.NewLine}");

            if (!string.IsNullOrEmpty(userInfo.UserMiddleName))
            {
                sb.Append($"Middle Name: {userInfo.UserMiddleName}{Environment.NewLine}");
            }
            if (!string.IsNullOrEmpty(userInfo.UserLastName))
            {
                sb.Append($"Last Name: {userInfo.UserLastName}");
            }          

            return sb.ToString();
        }

        private void ProcessUserInput(string[] input, out string firstName, out string middleName, out string lastName)
        {
            firstName = input?[0] ?? string.Empty;
            middleName = input != null
                ? input.Length >= 3
                    ? input[1]
                    : string.Empty
                : string.Empty;
            lastName = input != null
                ? input.Length == 2 
                    ? input[1]
                    : input.Length == 1 
                        ? string.Empty 
                        : input[input.Length - 1]
                : string.Empty; 
        }

        #endregion Private Methods     
    }
}
