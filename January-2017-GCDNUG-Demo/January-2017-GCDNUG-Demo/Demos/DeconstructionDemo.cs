﻿using System;
using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class DeconstructionDemo : AbstractDemo
    {
        #region Properties
        #endregion Properties

        #region Constructors

        public DeconstructionDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.AppendLine(ConsumeTupleStandardMessage());
            sb.AppendLine(AssignTupleToFreshVariablesMessage());
            sb.AppendLine(AssignTupleToFreshVariablesSingleVarMessage());
            sb.Append(AssignTupleToExistingVariablesMessage());

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private string ConsumeTupleStandardMessage()
        {
            var tuple = SuperAwesomeTuple(Input);

            var sb = new StringBuilder();

            sb.AppendLine($"{GetCurrentMethod().MethodSignature()}");
            sb.AppendLine($"Input: {tuple.input}");
            sb.AppendLine($"Input Reversed: {tuple.inputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(tuple.inputAsCharArray)}");
            sb.AppendLine($"Input Length: {tuple.inputLength}");

            return sb.ToString();
        }

        private string AssignTupleToFreshVariablesMessage()
        {
            // can also use var here rather than explicit types
            (string input, string inputReversed, char[] inputAsCharArray, int inputLength) = SuperAwesomeTuple(Input);

            var sb = new StringBuilder();

            sb.AppendLine($"{GetCurrentMethod().MethodSignature()}");
            sb.AppendLine($"Input: {input}");
            sb.AppendLine($"Input Reversed: {inputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(inputAsCharArray)}");
            sb.AppendLine($"Input Length: {inputLength}");

            return sb.ToString();
        }

        private string AssignTupleToFreshVariablesSingleVarMessage()
        {
            var (input, inputReversed, inputAsCharArray, inputLength) = SuperAwesomeTuple(Input);

            var sb = new StringBuilder();

            sb.AppendLine($"{GetCurrentMethod().MethodSignature()}");
            sb.AppendLine($"Input: {input}");
            sb.AppendLine($"Input Reversed: {inputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(inputAsCharArray)}");
            sb.AppendLine($"Input Length: {inputLength}");

            return sb.ToString();
        }

        private string AssignTupleToExistingVariablesMessage()
        {
            var input = "Some pre-existing value";
            var inputReversed = "Some other pre-existing value";
            char[] inputAsCharArray = {'s', 't', 'u', 'f', 'f'};
            var inputLength = 98172;

            (input, inputReversed, inputAsCharArray, inputLength) = SuperAwesomeTuple(Input);

            var sb = new StringBuilder();

            sb.AppendLine($"{GetCurrentMethod().MethodSignature()}");
            sb.AppendLine($"Input: {input}");
            sb.AppendLine($"Input Reversed: {inputReversed}");
            sb.AppendLine($"Input As Character Array: {new string(inputAsCharArray)}");
            sb.AppendLine($"Input Length: {inputLength}");

            return sb.ToString();
        }

        private static (string input, string inputReversed, char[] inputAsCharArray, int inputLength) SuperAwesomeTuple(object obj)
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