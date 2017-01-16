namespace January_2017_GCDNUG_Demo
{
    partial class DemoChooserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoChooserForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.getGreetingButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.demosGroupBox = new System.Windows.Forms.GroupBox();
            this.outVariablesRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.awaitRadioButton = new System.Windows.Forms.RadioButton();
            this.exceptionFiltersRadioButton = new System.Windows.Forms.RadioButton();
            this.nameofRadioButton = new System.Windows.Forms.RadioButton();
            this.expressionBodiedMembersRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nullConditionalRadioButton = new System.Windows.Forms.RadioButton();
            this.stringInterpolationRadioButton = new System.Windows.Forms.RadioButton();
            this.patternMatchingRadioButton = new System.Windows.Forms.RadioButton();
            this.tuplesRadioButton = new System.Windows.Forms.RadioButton();
            this.demosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(31, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Input";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(259, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.Stuff_Changed);
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
            // 
            // getGreetingButton
            // 
            this.getGreetingButton.Location = new System.Drawing.Point(277, 51);
            this.getGreetingButton.Name = "getGreetingButton";
            this.getGreetingButton.Size = new System.Drawing.Size(108, 23);
            this.getGreetingButton.TabIndex = 2;
            this.getGreetingButton.Text = "DO STUFF";
            this.getGreetingButton.UseVisualStyleBackColor = true;
            this.getGreetingButton.Click += new System.EventHandler(this.GetGreetingButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 104);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(761, 322);
            this.messageTextBox.TabIndex = 3;
            // 
            // demosGroupBox
            // 
            this.demosGroupBox.Controls.Add(this.tuplesRadioButton);
            this.demosGroupBox.Controls.Add(this.patternMatchingRadioButton);
            this.demosGroupBox.Controls.Add(this.outVariablesRadioButton);
            this.demosGroupBox.Controls.Add(this.label2);
            this.demosGroupBox.Controls.Add(this.awaitRadioButton);
            this.demosGroupBox.Controls.Add(this.exceptionFiltersRadioButton);
            this.demosGroupBox.Controls.Add(this.nameofRadioButton);
            this.demosGroupBox.Controls.Add(this.expressionBodiedMembersRadioButton);
            this.demosGroupBox.Controls.Add(this.label1);
            this.demosGroupBox.Controls.Add(this.nullConditionalRadioButton);
            this.demosGroupBox.Controls.Add(this.stringInterpolationRadioButton);
            this.demosGroupBox.Location = new System.Drawing.Point(801, 51);
            this.demosGroupBox.Name = "demosGroupBox";
            this.demosGroupBox.Size = new System.Drawing.Size(208, 375);
            this.demosGroupBox.TabIndex = 4;
            this.demosGroupBox.TabStop = false;
            this.demosGroupBox.Text = "Language Features";
            // 
            // outVariablesRadioButton
            // 
            this.outVariablesRadioButton.AutoSize = true;
            this.outVariablesRadioButton.Location = new System.Drawing.Point(10, 212);
            this.outVariablesRadioButton.Name = "outVariablesRadioButton";
            this.outVariablesRadioButton.Size = new System.Drawing.Size(88, 17);
            this.outVariablesRadioButton.TabIndex = 8;
            this.outVariablesRadioButton.TabStop = true;
            this.outVariablesRadioButton.Text = "Out Variables";
            this.outVariablesRadioButton.UseVisualStyleBackColor = true;
            this.outVariablesRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "C# 7";
            // 
            // awaitRadioButton
            // 
            this.awaitRadioButton.AutoSize = true;
            this.awaitRadioButton.Location = new System.Drawing.Point(10, 154);
            this.awaitRadioButton.Name = "awaitRadioButton";
            this.awaitRadioButton.Size = new System.Drawing.Size(126, 17);
            this.awaitRadioButton.TabIndex = 6;
            this.awaitRadioButton.TabStop = true;
            this.awaitRadioButton.Text = "\'await\' in Catch Block";
            this.awaitRadioButton.UseVisualStyleBackColor = true;
            this.awaitRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // exceptionFiltersRadioButton
            // 
            this.exceptionFiltersRadioButton.AutoSize = true;
            this.exceptionFiltersRadioButton.Location = new System.Drawing.Point(10, 131);
            this.exceptionFiltersRadioButton.Name = "exceptionFiltersRadioButton";
            this.exceptionFiltersRadioButton.Size = new System.Drawing.Size(102, 17);
            this.exceptionFiltersRadioButton.TabIndex = 5;
            this.exceptionFiltersRadioButton.TabStop = true;
            this.exceptionFiltersRadioButton.Text = "Exception Filters";
            this.exceptionFiltersRadioButton.UseVisualStyleBackColor = true;
            this.exceptionFiltersRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // nameofRadioButton
            // 
            this.nameofRadioButton.AutoSize = true;
            this.nameofRadioButton.Location = new System.Drawing.Point(10, 108);
            this.nameofRadioButton.Name = "nameofRadioButton";
            this.nameofRadioButton.Size = new System.Drawing.Size(178, 17);
            this.nameofRadioButton.TabIndex = 4;
            this.nameofRadioButton.TabStop = true;
            this.nameofRadioButton.Text = "\'nameof\' and Dictionary Initializer";
            this.nameofRadioButton.UseVisualStyleBackColor = true;
            this.nameofRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // expressionBodiedMembersRadioButton
            // 
            this.expressionBodiedMembersRadioButton.AutoSize = true;
            this.expressionBodiedMembersRadioButton.Location = new System.Drawing.Point(10, 84);
            this.expressionBodiedMembersRadioButton.Name = "expressionBodiedMembersRadioButton";
            this.expressionBodiedMembersRadioButton.Size = new System.Drawing.Size(157, 17);
            this.expressionBodiedMembersRadioButton.TabIndex = 3;
            this.expressionBodiedMembersRadioButton.TabStop = true;
            this.expressionBodiedMembersRadioButton.Text = "Expression-bodied Members";
            this.expressionBodiedMembersRadioButton.UseVisualStyleBackColor = true;
            this.expressionBodiedMembersRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# 6";
            // 
            // nullConditionalRadioButton
            // 
            this.nullConditionalRadioButton.AutoSize = true;
            this.nullConditionalRadioButton.Location = new System.Drawing.Point(10, 61);
            this.nullConditionalRadioButton.Name = "nullConditionalRadioButton";
            this.nullConditionalRadioButton.Size = new System.Drawing.Size(103, 17);
            this.nullConditionalRadioButton.TabIndex = 1;
            this.nullConditionalRadioButton.Text = "Null Propagation";
            this.nullConditionalRadioButton.UseVisualStyleBackColor = true;
            this.nullConditionalRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // stringInterpolationRadioButton
            // 
            this.stringInterpolationRadioButton.AutoSize = true;
            this.stringInterpolationRadioButton.Checked = true;
            this.stringInterpolationRadioButton.Location = new System.Drawing.Point(10, 38);
            this.stringInterpolationRadioButton.Name = "stringInterpolationRadioButton";
            this.stringInterpolationRadioButton.Size = new System.Drawing.Size(113, 17);
            this.stringInterpolationRadioButton.TabIndex = 0;
            this.stringInterpolationRadioButton.TabStop = true;
            this.stringInterpolationRadioButton.Text = "String Interpolation";
            this.stringInterpolationRadioButton.UseVisualStyleBackColor = true;
            this.stringInterpolationRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // patternMatchingRadioButton
            // 
            this.patternMatchingRadioButton.AutoSize = true;
            this.patternMatchingRadioButton.Location = new System.Drawing.Point(10, 236);
            this.patternMatchingRadioButton.Name = "patternMatchingRadioButton";
            this.patternMatchingRadioButton.Size = new System.Drawing.Size(106, 17);
            this.patternMatchingRadioButton.TabIndex = 9;
            this.patternMatchingRadioButton.TabStop = true;
            this.patternMatchingRadioButton.Text = "Pattern Matching";
            this.patternMatchingRadioButton.UseVisualStyleBackColor = true;
            this.patternMatchingRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // tuplesRadioButton
            // 
            this.tuplesRadioButton.AutoSize = true;
            this.tuplesRadioButton.Location = new System.Drawing.Point(10, 260);
            this.tuplesRadioButton.Name = "tuplesRadioButton";
            this.tuplesRadioButton.Size = new System.Drawing.Size(57, 17);
            this.tuplesRadioButton.TabIndex = 10;
            this.tuplesRadioButton.TabStop = true;
            this.tuplesRadioButton.Text = "Tuples";
            this.tuplesRadioButton.UseVisualStyleBackColor = true;
            // 
            // DemoChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 438);
            this.Controls.Add(this.demosGroupBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.getGreetingButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DemoChooserForm";
            this.Text = "January 2017 Gulf Coast .NET User Group Demo";
            this.demosGroupBox.ResumeLayout(false);
            this.demosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button getGreetingButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.GroupBox demosGroupBox;
        private System.Windows.Forms.RadioButton stringInterpolationRadioButton;
        private System.Windows.Forms.RadioButton nullConditionalRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton expressionBodiedMembersRadioButton;
        private System.Windows.Forms.RadioButton nameofRadioButton;
        private System.Windows.Forms.RadioButton exceptionFiltersRadioButton;
        private System.Windows.Forms.RadioButton awaitRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton outVariablesRadioButton;
        private System.Windows.Forms.RadioButton patternMatchingRadioButton;
        private System.Windows.Forms.RadioButton tuplesRadioButton;
    }
}

