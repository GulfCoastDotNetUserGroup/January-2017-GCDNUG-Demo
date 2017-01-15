﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using January_2017_GCDNUG_Demo.Demos;
using January_2017_GCDNUG_Demo.Interfaces;

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
                case "stringInterpolationRadioButton":
                    messageBuilders.Add(new StringInterpolationDemo(nameTextBox.Text));
                    break;
                case "nullConditionalRadioButton":
                    messageBuilders.Add(new NullPropagationOperatorDemo(nameTextBox.Text));
                    break;
                case "ExpressionBodiedMembersRadioButton":
                    messageBuilders.Add(new ExpressionBodiedMembersDemo(nameTextBox.Text));
                    break;
                case "nameofRadioButton":
                    messageBuilders.Add(new NameOfDemo(nameTextBox.Text));
                    break;
                case "exceptionFiltersRadioButton":
                    messageBuilders.Add(new ExceptionFiltersDemo(nameTextBox.Text));
                    break;
                case "awaitRadioButton":
                    bool useAwait = nameTextBox.Text.ToLower() == "yes";
                    messageTextBox.Text = new AwaitInCatchBlockDemo(useAwait).GetMessage();
                    return;
            }

            DisplayMessage(messageBuilders);
        }

        private void DisplayMessage(IEnumerable<IMessageBuilder> messageBuilders)
        {
            string message = messageBuilders.Aggregate(string.Empty, (current, messageBuilder) => current + (messageBuilder?.GetMessage() ?? string.Empty));
            messageTextBox.Text = message;
        }

        #region Events

        private void GetGreetingButton_Click(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = demosGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedRadioButton == null)
            {
                return;
            }

            GetMessage(checkedRadioButton);
        }

        private void Stuff_Changed(object sender, EventArgs e)
        {
            messageTextBox.Text = string.Empty;
        }

        #endregion Events
    }
}