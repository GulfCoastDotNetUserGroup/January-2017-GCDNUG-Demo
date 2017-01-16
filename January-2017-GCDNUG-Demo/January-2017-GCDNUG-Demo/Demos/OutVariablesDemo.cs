using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Misc;
using System.Text;
using static System.Reflection.MethodBase;
using static System.Environment;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;

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

            sb.AppendLine($"OLD OUT VARIABLES{NewLine}");
            sb.AppendLine($"{GetMessageWithOldOutVariables()}{DoubleSpace}");
            sb.AppendLine($"NEW OUT VARIABLES{NewLine}");
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

            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{BuildMessage(userInfo)}";
        }

        private string GetMessageWithNewOutVariables()
        {
            ProcessUserInput(Input.Split(' '), out string firstName, out string middleName, out string lastName);

            UserInfo userInfo = new UserInfo(firstName, middleName, lastName);

            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{BuildMessage(userInfo)}";
        }

        private string BuildMessage(UserInfo userInfo)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {userInfo.UserFirstName}");

            if (!string.IsNullOrEmpty(userInfo.UserMiddleName))
            {
                sb.AppendLine($"Middle Name: {userInfo.UserMiddleName}");
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
