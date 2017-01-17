using System.Text;
using January_2017_GCDNUG_Demo.Helpers;

// Static usings
using static System.Reflection.MethodBase;
using static System.Environment;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;

namespace January_2017_GCDNUG_Demo.Demos
{
    /// <summary>
    /// !! EXPRESSION-BODIED MEMBERS !!
    /// 
    /// If you have a property or method that contains a single line of code, you can use the “=>” operator 
    /// to express it instead of defining the body using curly braces.
    /// </summary>
    public class ExpressionBodiedMembersDemo : AbstractDemo
    {
        #region Properties

        // Old school single line get only property
        private string OldSchoolGetOnlyPropertyMessage
        {
            get
            {
                return $"{Hello}{Input}!";
            }
        }

        // Expression-bodied Member - single line get only property
        private string ExpressionBodiedProperyMessage => $"{Hello}{Input}!";

        #endregion Properties

        #region Constructors

        public ExpressionBodiedMembersDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"OLD WAY{NewLine}");
            sb.AppendLine($"{GetOldSchoolSingleLineMethodMessage()}{NewLine}");
            sb.AppendLine($"{NewLine}NEW WAY{NewLine}");
            sb.Append(GetExpressionBodiedMethodMessage());

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // OLD SINGLE LINE
        private string GetOldSchoolSingleLineMethodMessage()
        {
            return $"{GetCurrentMethod().MethodSignature()}{NewLine}{Hello}{Input}!";
        }

        // NEW HOTNESS
        private string GetExpressionBodiedMethodMessage() => $"{GetCurrentMethod().MethodSignature()}{NewLine}{Hello}{Input}!";

        #endregion Private Methods
    }
}
