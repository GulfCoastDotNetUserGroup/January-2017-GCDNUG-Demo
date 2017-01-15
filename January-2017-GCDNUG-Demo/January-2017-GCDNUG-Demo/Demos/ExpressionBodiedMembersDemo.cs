using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;

// Static usings
using static System.Reflection.MethodBase;


namespace January_2017_GCDNUG_Demo.Demos
{
    /// <summary>
    /// !! EXPRESSION-BODIED MEMBERS !!
    /// 
    /// If you have a property or method that contains a single line of code, you can use the “=>” operator 
    /// to express it instead of defining the body using curly braces.
    /// </summary>
    public class ExpressionBodiedMembersDemo : IMessageBuilder
    {
        #region Properties

        public string Name { get; set; }

        public string Message { get; set; }

        // Old school single line get only property
        public string OldSchoolGetOnlyPropertyMessage
        {
            get
            {
                return $"{DemoConstants.Hello}{Name}!  {GetCurrentMethod().MethodSignature()}";
            }
        }

        // Expression-bodied Member - single line get only property
        public string ExpressionBodiedMemberMessage => $"{DemoConstants.Hello}{Name}!  {GetCurrentMethod().MethodSignature()}";

        #endregion Properties

        #region Constructors

        public ExpressionBodiedMembersDemo(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Public Methods

        public string GetMessage()
        {
            var sb = new StringBuilder();

            sb.Append(GetOldSchoolSingleLineMessage());
            sb.Append(DemoConstants.DoubleSpace);

            sb.Append(GetExpressionBodiedMemberMessage());
            sb.Append(DemoConstants.DoubleSpace);

            sb.Append(OldSchoolGetOnlyPropertyMessage);
            sb.Append(DemoConstants.DoubleSpace);

            sb.Append(ExpressionBodiedMemberMessage);

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        // OLD SINGLE LINE
        private string GetOldSchoolSingleLineMessage()
        {
            return $"{DemoConstants.Hello}{Name}!  {GetCurrentMethod().MethodSignature()}";
        }

        // NEW HOTNESS
        private string GetExpressionBodiedMemberMessage() => $"{DemoConstants.Hello}{Name}!  {GetCurrentMethod().MethodSignature()}";

        #endregion Private Methods
    }
}
