using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using January_2017_GCDNUG_Demo.Demos;
using January_2017_GCDNUG_Demo.Interfaces;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;

namespace January_2017_GCDNUG_Demo
{
    public partial class DemoChooserForm : Form
    {
        public DemoChooserForm()
        {
            InitializeComponent();
        }

        private void GetMessage(Control checkedRadioButton)
        {
            var messageBuilders = new List<IMessageBuilder>();

            switch (checkedRadioButton.Name)
            {
                case StringInterpolationRadioButton:
                    messageBuilders.Add(new StringInterpolationDemo(nameTextBox.Text));
                    break;
                case NullConditionalRadioButton:
                    messageBuilders.Add(new NullPropagationOperatorDemo(nameTextBox.Text));
                    break;
                case ExpressionBodiedMembersRadioButton:
                    messageBuilders.Add(new ExpressionBodiedMembersDemo(nameTextBox.Text));
                    break;
                case NameofRadioButton:
                    messageBuilders.Add(new NameOfDemo(nameTextBox.Text));
                    break;
                case ExceptionFiltersRadioButton:
                    messageBuilders.Add(new ExceptionFiltersDemo(nameTextBox.Text));
                    break;
                case AwaitRadioButton:
                    messageTextBox.Text = new AwaitInCatchBlockDemo(nameTextBox.Text.ToLower() == "yes").GetMessage();
                    return;
                case OutVariablesRadioButton:
                    messageBuilders.Add(new OutVariablesDemo(nameTextBox.Text));
                    break;
                case PatternMatchingRadioButton:
                    messageBuilders.Add(new PatternMatchingDemo(nameTextBox));
                    break;
                case TuplesRadioButton:
                    messageBuilders.Add(new TuplesDemo(nameTextBox.Text));
                    break;
                case DeconstructionRadioButton:
                    messageBuilders.Add(new DeconstructionDemo(nameTextBox.Text));
                    break;
                case LocalFunctionsRadioButton:
                    messageBuilders.Add(new LocalFunctionsDemo(nameTextBox.Text));
                    break;
                case RefReturnsAndLocalsRadioButton:
                    messageBuilders.Add(new RefReturnsAndLocalsDemo(nameTextBox.Text));
                    break;
            }

            DisplayMessage(messageBuilders);
        }

        private void DisplayMessage(IEnumerable<IMessageBuilder> messageBuilders)
        {
            string message = messageBuilders.Aggregate(string.Empty, (current, messageBuilder) => current + (messageBuilder?.GetMessage() ?? string.Empty));
            messageTextBox.Text = message;
        }

        private void DoStuff()
        {
            RadioButton checkedRadioButton = demosGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedRadioButton == null)
            {
                return;
            }

            GetMessage(checkedRadioButton);
        }

        private void SetLanguageImage(Control checkedRadioButton)
        {
            bool isVersion6;
            switch (checkedRadioButton.Name)
            {               
                case OutVariablesRadioButton:
                    isVersion6 = false;
                    break;
                case PatternMatchingRadioButton:
                    isVersion6 = false;
                    break;
                case TuplesRadioButton:
                    isVersion6 = false;
                    break;
                case DeconstructionRadioButton:
                    isVersion6 = false;
                    break;
                case LocalFunctionsRadioButton:
                    isVersion6 = false;
                    break;
                case RefReturnsAndLocalsRadioButton:
                    isVersion6 = false;
                    break;
                default:
                    isVersion6 = true;
                    break;
            }
            languageVersionPictureBox.Visible = isVersion6;
            languageVersionPictureBox2.Visible = !isVersion6;
        }

        #region Events

        private void GetGreetingButton_Click(object sender, EventArgs e)
        {
            DoStuff();
        }

        private void Stuff_Changed(object sender, EventArgs e)
        {
            //messageTextBox.Text = string.Empty;

            RadioButton checkedRadioButton = demosGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedRadioButton == null)
            {
                return;
            }

            SetLanguageImage(checkedRadioButton);
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoStuff();
            }
        }

        #endregion Events

    }
}
