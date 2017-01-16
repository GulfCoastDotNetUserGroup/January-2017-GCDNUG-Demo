using System;
using System.Text;
using static System.Reflection.MethodBase;
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
            sb.Append($"OLD WAY WITH CUSTOM TYPE{NewLine}");
            sb.Append($"{MessageWithCustomType()}{DoubleSpace}");
            sb.Append($"OLD WAY WITH OUT PARAMETERS{NewLine}");
            sb.Append($"{MessageWithOutParameters()}");
            
            return sb.ToString();
        }

        private string GetMessageNewWay()
        {
            var sb = new StringBuilder();
            sb.Append($"NEW WAY WITH TUPLE{NewLine}");
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
            sb.Append($"Input: {input}{NewLine}");
            sb.Append($"Input Reversed: {inputReversed}{NewLine}");
            sb.Append($"Input As Character Array: {new string(inputAsCharArray)}{NewLine}");
            sb.Append($"Input Length: {inputLength}{NewLine}");
            return sb.ToString();
        }

        private string MessageWithCustomType()
        {
            var customType = new CustomType(Input);

            var sb = new StringBuilder();
            sb.Append($"Input: {customType.Input}{NewLine}");
            sb.Append($"Input Reversed: {customType.InputReversed}{NewLine}");
            sb.Append($"Input As Character Array: {new string(customType.InputAsCharArray)}{NewLine}");
            sb.Append($"Input Length: {customType.InputLength}{NewLine}");
            return sb.ToString();
        }

        private string MessageWithTuple()
        {
            var newHotness = NewWayWithTuple(Input);

            var sb = new StringBuilder();
            sb.Append($"Input: {newHotness.input}{NewLine}");
            sb.Append($"Input Reversed: {newHotness.inputReversed}{NewLine}");
            sb.Append($"Input As Character Array: {new string(newHotness.inputAsCharArray)}{NewLine}");
            sb.Append($"Input Length: {newHotness.inputLength}{NewLine}");
            return sb.ToString();
        }

        #endregion GET MESSAGES

        private class CustomType
        {
            public string Input { get; set; }
            public string InputReversed { get; set; }
            public char[] InputAsCharArray { get; set; }
            public int InputLength { get; set; }

            public CustomType(object obj)
            {
                Input = obj.ToString();
                InputAsCharArray = Input.ToCharArray();
                var tca = Input.ToCharArray();
                Array.Reverse(tca);
                InputReversed = new string(tca);
                InputLength = Input.Length;
            }
        }

        private void OldWayWithOutParameters(object obj, out string input, out string inputReversed, out char[] inputAsCharArray, out int inputLength)
        {
            input = obj.ToString();
            inputAsCharArray = input.ToCharArray();
            var tca = input.ToCharArray();
            Array.Reverse(tca);
            inputReversed = new string(tca);
            inputLength = input.Length;
        }

        private (string input, string inputReversed, char[] inputAsCharArray, int inputLength) NewWayWithTuple(object obj)
        {
            var input = obj.ToString();
            var inputAsCharArray = input.ToCharArray();
            var tca = input.ToCharArray();
            Array.Reverse(tca);
            var inputReversed = new string(tca);
            var inputLength = input.Length;
            return (input, inputReversed, inputAsCharArray, inputLength);
        }

        #endregion Private Methods
    }
}
