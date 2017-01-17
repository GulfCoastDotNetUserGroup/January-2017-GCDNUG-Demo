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
            ProcessUserInput(Input, out firstName, out middleName, out lastName);

            var userInfo = new UserInfo(firstName, middleName, lastName);

            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{BuildMessage(userInfo)}";
        }

        private string GetMessageWithNewOutVariables()
        {
            ProcessUserInput(Input, out string firstName, out string middleName, out string lastName);

            var userInfo = new UserInfo(firstName, middleName, lastName);

            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{BuildMessage(userInfo)}";
        }

        private static string BuildMessage(UserInfo userInfo)
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrEmpty(userInfo.UserFirstName))
            {
                sb.AppendLine($"First Name: {userInfo.UserFirstName}");

                if (!string.IsNullOrEmpty(userInfo.UserMiddleName))
                {
                    sb.AppendLine($"Middle Name: {userInfo.UserMiddleName}");
                }
                if (!string.IsNullOrEmpty(userInfo.UserLastName))
                {
                    sb.Append($"Last Name: {userInfo.UserLastName}");
                }
            }
            else
            {
                sb.Append("You need to enter your name dummy!");
            }      

            return sb.ToString();
        }

        private static void ProcessUserInput(string i, out string firstName, out string middleName, out string lastName)
        {
            string[] input = i?.Split(' ') ?? new string[]{};

            firstName = input.Length > 0
                ? !string.IsNullOrEmpty(input[0])
                    ? input[0]
                    : null
                : null;

            middleName = input.Length >= 3
                ? input[1]
                : null;

            lastName = input.Length > 0
                ? input.Length == 2
                    ? input[1]
                    : input.Length == 1
                        ? null
                        : input[input.Length - 1]
                : null;
        }

        #endregion Private Methods     
    }
}
