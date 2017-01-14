using System.Reflection;
using System.Text;
using January2017GCDNUG;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
// Static usings

namespace January_2017_GCDNUG_Demo.Demos
{
    /// <summary>
    /// !! EXPRESSION-BODIED MEMBERS !!
    /// 
    /// If you have a property or method that contains a single line of code, you can use the “=>” operator 
    /// to express it instead of defining the body using curly braces.
    /// </summary>
    class ExpressionBodiedMembersDemo : IMessageBuilder
    {
        #region Properties

        public string Name { get; set; }

        public string Message { get; set; }

        // Expression-bodied Member - single-line get only property
        public string ExpressionBodiedMemberMessage => $"{DemoConstants.Hello}{Name}!  {MethodBase.GetCurrentMethod().MethodSignature()}";

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

            OldSchoolSingleLineMethodSetMessage();
            sb.Append(Message);
            sb.Append(DemoConstants.DoubleSpace);

            ExpressionBodiedMemberSetMessage();
            sb.Append(Message);
            sb.Append(DemoConstants.DoubleSpace);

            sb.Append(GetOldSchoolSingleLineMessage());
            sb.Append(DemoConstants.DoubleSpace);

            sb.Append(GetExpressionBodiedMemberMessage());
            sb.Append(DemoConstants.DoubleSpace);

            sb.Append(ExpressionBodiedMemberMessage);

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        #region Voids

        // OLD SINGLE LINE
        private void OldSchoolSingleLineMethodSetMessage()
        {
            Message = $"{DemoConstants.Hello}{Name}!  {MethodBase.GetCurrentMethod().MethodSignature()}";
        }

        // NEW HOTNESS
        private void ExpressionBodiedMemberSetMessage() => Message = $"{DemoConstants.Hello}{Name}!  {MethodBase.GetCurrentMethod().MethodSignature()}";

        #endregion Voids

        #region Strings

        // OLD SINGLE LINE
        private string GetOldSchoolSingleLineMessage()
        {
            return $"{DemoConstants.Hello}{Name}!  {MethodBase.GetCurrentMethod().MethodSignature()}";
        }

        // NEW HOTNESS
        private string GetExpressionBodiedMemberMessage() => $"{DemoConstants.Hello}{Name}!  {MethodBase.GetCurrentMethod().MethodSignature()}";

        #endregion Strings

        #endregion Private Methods
    }
}
