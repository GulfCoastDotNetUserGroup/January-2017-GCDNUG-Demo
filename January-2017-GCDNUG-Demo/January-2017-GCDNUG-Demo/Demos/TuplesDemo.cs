using System;
using System.Text;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;
using static System.Environment;

namespace January_2017_GCDNUG_Demo.Demos
{
    /// <summary>
    /// As of creating this demo it requires the System.ValueTuple NuGet package
    /// </summary>
    public class TuplesDemo : AbstractDemo
    {
        #region Properties
        #endregion Properties

        #region Constructors

        public TuplesDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            return $"{GetMessageOldWay()}{DoubleSpace}{GetMessageNewWay()}";
        }

        #endregion Public Methods

        #region Private Methods

        #region GET MESSAGES

        private string GetMessageOldWay()
        {
            var sb = new StringBuilder();
            sb.AppendLine("OLD WAY WITH CUSTOM TYPE");
            sb.AppendLine($"{MessageWithCustomType()}{NewLine}");
            sb.AppendLine($"OLD WAY WITH OUT PARAMETERS");
            sb.Append($"{MessageWithOutParameters()}");
            
            return sb.ToString();
        }

        private string GetMessageNewWay()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"NEW WAY WITH TUPLE");
            sb.Append(MessageWithTuple());
            return sb.ToString();
        }

        private string MessageWithOutParameters()
        {
            string input;
            string inputReversed;
            char[] inputAsCharArray;
            int inputLength;
            OldWayWithOutParameters(Input, out input, out inputReversed, out inputAsCharArray, out inputLength);

            var sb = new StringBuilder();
            sb.AppendLine($"Input: {input}");
            sb.AppendLine($"Input Reversed: {inputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(inputAsCharArray)}");
            sb.AppendLine($"Input Length: {inputLength}");
            return sb.ToString();
        }

        private string MessageWithCustomType()
        {
            var customType = new CustomType(Input);

            var sb = new StringBuilder();
            sb.AppendLine($"Input: {customType.Input}");
            sb.AppendLine($"Input Reversed: {customType.InputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(customType.InputAsCharArray)}");
            sb.AppendLine($"Input Length: {customType.InputLength}");
            return sb.ToString();
        }

        private string MessageWithTuple()
        {
            var newHotness = NewWayWithTuple(Input);

            var sb = new StringBuilder();
            sb.AppendLine($"Input: {newHotness.input}");
            sb.AppendLine($"Input Reversed: {newHotness.inputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(newHotness.inputAsCharArray)}");
            sb.AppendLine($"Input Length: {newHotness.inputLength}");
            return sb.ToString();
        }

        #endregion GET MESSAGES

        private class CustomType
        {
            public string Input { get; private set; }
            public string InputReversed { get; private set; }
            public char[] InputAsCharArray { get; private set; }
            public int InputLength { get; private set; }

            public CustomType(object obj)
            {
                Input = obj.ToString();
                InputAsCharArray = Input.ToCharArray();
                char[] tca = Input.ToCharArray();
                Array.Reverse(tca);
                InputReversed = new string(tca);
                InputLength = Input.Length;
            }
        }

        private static void OldWayWithOutParameters(object obj, out string input, out string inputReversed, out char[] inputAsCharArray, out int inputLength)
        {
            input = obj.ToString();
            inputAsCharArray = input.ToCharArray();
            char[] tca = input.ToCharArray();
            Array.Reverse(tca);
            inputReversed = new string(tca);
            inputLength = input.Length;
        }

        private static (string input, string inputReversed, char[] inputAsCharArray, int inputLength) NewWayWithTuple(object obj)
        {
            string input = obj.ToString();
            char[] inputAsCharArray = input.ToCharArray();
            char[] tca = input.ToCharArray();
            Array.Reverse(tca);
            string inputReversed = new string(tca);
            int inputLength = input.Length;
            return (input, inputReversed, inputAsCharArray, inputLength);
        }

        #endregion Private Methods
    }
}
