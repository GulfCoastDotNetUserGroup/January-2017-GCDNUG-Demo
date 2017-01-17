using System.Linq;
using System.Text;
using January_2017_GCDNUG_Demo.Misc;

namespace January_2017_GCDNUG_Demo.Demos
{
    /// <summary>
    /// Just like you can pass things by reference (with the ref modifier) in C#, you can now return them by reference, 
    /// and also store them by reference in local variables.
    /// </summary>
    public class RefReturnsAndLocalsDemo : AbstractDemo
    {
        #region Properties
        #endregion Properties

        #region Constants

        private const string BadInputMessage = "Please enter two numbers in the input field (The one to replace and its replacement)";

        #endregion Constants

        #region Constructors

        public RefReturnsAndLocalsDemo(string input)
        {
            Input = input;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            return BuildMessage();
        }

        #endregion Public Methods

        #region Private Methods

        private string BuildMessage()
        {
            string[] inputArray = Input.Split(' ');
            int[] intArray = { 4, 8, 15, 16, 23, 42 };

            var sb = new StringBuilder();
            sb.AppendLine($"The numbers available to change are {IntArrayToCommaDelimitedString(intArray)}");

            if (inputArray.Length == 2)
            {
                if (int.TryParse(inputArray[0], out int firstNumber) &&
                    int.TryParse(inputArray[1], out int secondNumber))
                {
                    bool foundNumberToReplace = false;

                    MakeTheMagicHappen(ref intArray, firstNumber, secondNumber, ref foundNumberToReplace);

                    if (foundNumberToReplace)
                    {
                        sb.AppendLine($"The numbers are now {IntArrayToCommaDelimitedString(intArray)} after making your change");
                    }
                    else
                    {
                        sb.AppendLine($"Did your mother drop you on you head a lot when you were young? {firstNumber} is not one of the numbers!");
                        sb.AppendLine("Do you want to take another crack at this or is it too difficult for you?");
                    }
                }
                else
                {
                    sb.AppendLine(BadInputMessage);
                }
            }
            else
            {
                sb.AppendLine(BadInputMessage);
            }

            return sb.ToString();
        }

        private void MakeTheMagicHappen(ref int[] ia, int numberToReplace, int replacementNumber, ref bool found)
        {
            ref int place = ref Find(numberToReplace, ia, out found); //aliases firstNumbers's place in the array
            if (found)
            {
                place = replacementNumber; // replaces firstNumber with secondNumber in the array
            }
        }

        private ref int Find(int number, int[] numbers, out bool found)
        {
            if (numbers == null || numbers.Length == 0) throw new DotNetUsersGroupException();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    found = true;
                    return ref numbers[i]; // return the location, not the value
                }
            }
            found = false;
            return ref numbers[0];
        }   

        private string IntArrayToCommaDelimitedString(int[] ia)
        {
            var sb = new StringBuilder();

            foreach (int i in ia)
            {
                sb.Append(i);
                if (i != ia.Last()) sb.Append(", ");
            }

            return sb.ToString();
        }

        #endregion Private Methods
    }
}
