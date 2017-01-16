using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Misc;

// Static usings
using static System.Reflection.MethodBase;
using static System.Environment;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class NullPropagationOperatorDemo : AbstractDemo
    {
        #region Properties

        public string NullUserOrNameMessage { get; set; } = "I see that you have opted to not provide a name. What are you trying to hide?";

        #endregion Properties

        #region Constructors

        public NullPropagationOperatorDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var user = !string.IsNullOrEmpty(Input) 
                ? new User(Input) 
                : new User();

            var sb = new StringBuilder();
            sb.AppendLine($"OLD WAY - NULL CHECKS{NewLine}");
            sb.AppendLine($"{GreetingWithNullChecks(user)}{DoubleSpace}");
            sb.AppendLine($"NEW WAY - NULL PROPAGATION OPERATOR{NewLine}");
            sb.Append($"{GreetingWithNullPropagationOperator(user)}");

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // OLD WAY
        private string GreetingWithNullChecks(User user)
        {
            if (user == null || user.Name == null)
            {
                return $"{GetCurrentMethod().MethodSignature()}{NewLine}{Hello}{NullUserOrNameMessage}";
            }
            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{Hello}{user.Name}";
        }

        // NEW HOTNESS
        private string GreetingWithNullPropagationOperator(User user)
        {
            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{Hello}{user?.Name ?? NullUserOrNameMessage}";
        }

        #endregion Private Methods
    }
}
