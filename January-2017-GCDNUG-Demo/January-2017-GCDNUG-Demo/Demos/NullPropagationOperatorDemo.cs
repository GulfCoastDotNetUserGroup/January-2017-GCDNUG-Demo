using System;
using System.Reflection;
using System.Text;
using January2017GCDNUG;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
// Static usings

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
            var user = new User(Name);
            string doubleSpace = $"{Environment.NewLine}{Environment.NewLine}";

            var sb = new StringBuilder();
            sb.Append(GreetingWithNullChecks(user) ?? string.Empty);
            sb.Append(DemoConstants.DoubleSpace);
            sb.Append(GreetingWithNullPropagationOperator(user) ?? string.Empty);
            sb.Append(DemoConstants.DoubleSpace);
            sb.Append(GreetingWithNullPropagationOperator(null) ?? string.Empty);
            sb.Append(DemoConstants.DoubleSpace);

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // OLD WAY
        private string GreetingWithNullChecks(User user)
        {
            if (user == null || user.Name == null)
            {
                return $"{DemoConstants.Hello}{NullUserOrNameMessage}  {MethodBase.GetCurrentMethod().MethodSignature()}";
            }
            return $"{DemoConstants.Hello}{user.Name}  {MethodBase.GetCurrentMethod().MethodSignature()}";
        }

        // NEW HOTNESS
        private string GreetingWithNullPropagationOperator(User user)
        {
            return $"{DemoConstants.Hello}{user?.Name ?? NullUserOrNameMessage}  {MethodBase.GetCurrentMethod().MethodSignature()}";
        }

        #endregion Private Methods
    }
}
