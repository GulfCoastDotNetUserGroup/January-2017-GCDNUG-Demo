using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Misc;
using System.Text;
using static System.Reflection.MethodBase;
using static System.Environment;
using System.Windows.Forms;

namespace January_2017_GCDNUG_Demo.Demos
{
    /// <summary>
    /// It is common to want to return more than one value from a method. The options available today are less than optimal:
    ///     1. Out parameters: Use is clunky (even with the improvements described above), and they don’t work with async methods.
    ///     2. System.Tuple return types: Verbose to use and require an allocation of a tuple object.
    ///     3. Custom-built transport type for every method: A lot of code overhead for a type whose purpose is just to temporarily group a few values
    ///     4. Anonymous types returned through a dynamic return type: High performance overhead and no static type checking.
    /// To do better at this, C# 7.0 adds tuple types and tuple literals:
    /// </summary>
    public class PatternMatchingDemo : AbstractDemo
    {
        #region Constants

        private const string Ridicule = "You're not very good at this.";

        private const string MakingMeSad = "You are making me sad. How hard is it to type some stuff in a box?";

        #endregion Constants

        #region Properties
        #endregion Properties

        #region Constructors

        public PatternMatchingDemo(object obj)
        {
            if (obj is TextBox textBox) Input = textBox.Text;
            else if (obj is string s) Input = s;
            else Input = string.Empty;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            return !string.IsNullOrEmpty(Input) 
                ? $"{GetMessageOldWay()}{GetMessageNewWay()}{GetMessagesWithSwitchStatement()}" 
                : MakingMeSad;
        }

        #endregion Public Methods

        #region Private Methods

        #region GET MESSAGES

        private string GetMessageOldWay()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"'IS' EXPRESSION THE OLD WAY{NewLine}");

            int i;
            if (int.TryParse(Input, out i))
            {
                sb.AppendLine("Input passed as integer");
                sb.Append(ProcessMessageWithIsExpressionTheOldWay(i));
            }

            sb.AppendLine("Input passed as a string");
            sb.Append(ProcessMessageWithIsExpressionTheOldWay(Input));
            sb.Append(NewLine);

            return sb.ToString();
        }

        private string GetMessageNewWay()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"'IS' EXPRESSION WITH PATTERNS{NewLine}");

            if (int.TryParse(Input, out int i))
            {
                sb.AppendLine("Input passed as integer");
                sb.Append($"{ProcessMessageWithIsExpressionWithPatterns(i)}");
            }

            sb.AppendLine("Input passed as a string");
            sb.AppendLine(ProcessMessageWithIsExpressionTheOldWay(Input));

            return sb.ToString();
        }

        private string GetMessagesWithSwitchStatement()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"'SWITCH' STATEMENT WITH PATTERNS{NewLine}");

            // Pass as string
            sb.AppendLine(ProcessMessageWithPatternsInSwitchStatement(Input));
            
            // Pass as int
            if (int.TryParse(Input, out int i)) sb.AppendLine(ProcessMessageWithPatternsInSwitchStatement(i));

            // Pass as double
            if (double.TryParse(Input, out double d)) sb.AppendLine(ProcessMessageWithPatternsInSwitchStatement(d));

            // Pass as UserInput object
            var userInput = new UserInput(Input);
            sb.AppendLine(ProcessMessageWithPatternsInSwitchStatement(userInput));

            return sb.ToString();
        }

        #endregion GET MESSAGES

        private static string ProcessMessageWithIsExpressionTheOldWay(object obj)
        {
            var sb = new StringBuilder();
            sb.AppendLine(GetCurrentMethod().MethodSignature());

            int i;

            if (obj is int)
            {
                i = (int)obj;
                sb.AppendLine(GetValidIntegerMessage(i));
            }
            else if (obj is string && int.TryParse(obj.ToString(), out i))
            {
                sb.AppendLine(GetValidIntegerMessage(i));
            }
            else
            {
                sb.AppendLine(Ridicule);
            }
            sb.Append(NewLine);
          
            return sb.ToString();
        }

        private static string ProcessMessageWithIsExpressionWithPatterns(object obj)
        {
            var sb = new StringBuilder();
            sb.AppendLine(GetCurrentMethod().MethodSignature());

            sb.AppendLine((obj is int i || (obj is string s && int.TryParse(s, out i))) 
                ? GetValidIntegerMessage(i)
                : Ridicule);

            sb.Append(NewLine);

            return sb.ToString();
        }

        /// <summary>
        /// ****REMINDER****
        /// This demostrates the new generalization of 'switch' (You can switch on any type, not just primitives) as well as patterns in 'case' clauses
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string ProcessMessageWithPatternsInSwitchStatement(object obj)
        {
            switch (obj)
            {
                case string s:
                    return $"Your input of '{s}' was passed in as a string.";
                case int i:
                    return $"Your input of '{i}' was passed in as an integer.";
                case double d:
                    return $"Your input of '{d}' was passed in as a double.";
                case UserInput ui:
                    return $"Your input of '{ui.Input}' was passed in as a UserInput object.";
                default:
                    return "I'm not sure what type of object you passed in but it wasn't one I was checking for.";
            }        
        }

        private static string GetValidIntegerMessage(int i)
        {
            return $"You have entered {i} which is a valid integer. {i} squared is {i * i}";
        }

        #endregion Private Methods

    }
}
