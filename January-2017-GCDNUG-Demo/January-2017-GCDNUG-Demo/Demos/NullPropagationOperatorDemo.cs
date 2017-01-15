using System;
using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;

// Static usings
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class NullPropagationOperatorDemo : IMessageBuilder
    {
        #region Properties

        public string Name { get; set; }

        #region Auto Property Demo

        public string NullUserOrNameMessage { get; set; } = "I see that you have opted to not provide a name. What are you trying to hide?";

        #endregion Auto Property Demo

        #endregion Properties

        #region Constructors

        public NullPropagationOperatorDemo(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Public Methods

        public string GetMessage()
        {
            var user = !string.IsNullOrEmpty(Name) 
                ? new User(Name) 
                : new User();

            var sb = new StringBuilder();
            sb.Append($"OLD WAY - NULL CHECKS{DemoConstants.DoubleSpace}");
            sb.Append($"{GreetingWithNullChecks(user)}{DemoConstants.DoubleSpace}{Environment.NewLine}");
            sb.Append($"NEW WAY - NULL PROPAGATION OPERATOR{DemoConstants.DoubleSpace}");
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
                return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{DemoConstants.Hello}{NullUserOrNameMessage}";
            }
            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{DemoConstants.Hello}{user.Name}";
        }

        // NEW HOTNESS
        private string GreetingWithNullPropagationOperator(User user)
        {
            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{DemoConstants.Hello}{user?.Name ?? NullUserOrNameMessage}";
        }

        #endregion Private Methods
    }
}
