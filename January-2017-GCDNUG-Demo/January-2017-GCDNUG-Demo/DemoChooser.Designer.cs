﻿namespace January_2017_GCDNUG_Demo
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
            this.refReturnsAndLocalsRadioButton = new System.Windows.Forms.RadioButton();
            this.localFunctionsRadioButton = new System.Windows.Forms.RadioButton();
            this.deconstructionRadioButton = new System.Windows.Forms.RadioButton();
            this.tuplesRadioButton = new System.Windows.Forms.RadioButton();
            this.patternMatchingRadioButton = new System.Windows.Forms.RadioButton();
            this.outVariablesRadioButton = new System.Windows.Forms.RadioButton();
            this.awaitRadioButton = new System.Windows.Forms.RadioButton();
            this.exceptionFiltersRadioButton = new System.Windows.Forms.RadioButton();
            this.nameofRadioButton = new System.Windows.Forms.RadioButton();
            this.expressionBodiedMembersRadioButton = new System.Windows.Forms.RadioButton();
            this.nullConditionalRadioButton = new System.Windows.Forms.RadioButton();
            this.stringInterpolationRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languageVersionPictureBox = new System.Windows.Forms.PictureBox();
            this.languageVersionPictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.demosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageVersionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageVersionPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Input";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(259, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
            // 
            // getGreetingButton
            // 
            this.getGreetingButton.BackColor = System.Drawing.Color.Azure;
            this.getGreetingButton.Location = new System.Drawing.Point(277, 51);
            this.getGreetingButton.Name = "getGreetingButton";
            this.getGreetingButton.Size = new System.Drawing.Size(108, 23);
            this.getGreetingButton.TabIndex = 2;
            this.getGreetingButton.Text = "DO STUFF";
            this.getGreetingButton.UseVisualStyleBackColor = false;
            this.getGreetingButton.Click += new System.EventHandler(this.GetGreetingButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(12, 112);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(761, 322);
            this.messageTextBox.TabIndex = 3;
            // 
            // demosGroupBox
            // 
            this.demosGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.demosGroupBox.Controls.Add(this.refReturnsAndLocalsRadioButton);
            this.demosGroupBox.Controls.Add(this.localFunctionsRadioButton);
            this.demosGroupBox.Controls.Add(this.deconstructionRadioButton);
            this.demosGroupBox.Controls.Add(this.tuplesRadioButton);
            this.demosGroupBox.Controls.Add(this.patternMatchingRadioButton);
            this.demosGroupBox.Controls.Add(this.outVariablesRadioButton);
            this.demosGroupBox.Controls.Add(this.awaitRadioButton);
            this.demosGroupBox.Controls.Add(this.exceptionFiltersRadioButton);
            this.demosGroupBox.Controls.Add(this.nameofRadioButton);
            this.demosGroupBox.Controls.Add(this.expressionBodiedMembersRadioButton);
            this.demosGroupBox.Controls.Add(this.nullConditionalRadioButton);
            this.demosGroupBox.Controls.Add(this.stringInterpolationRadioButton);
            this.demosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demosGroupBox.Location = new System.Drawing.Point(801, 103);
            this.demosGroupBox.Name = "demosGroupBox";
            this.demosGroupBox.Size = new System.Drawing.Size(223, 331);
            this.demosGroupBox.TabIndex = 4;
            this.demosGroupBox.TabStop = false;
            this.demosGroupBox.Text = "Language Features";
            // 
            // refReturnsAndLocalsRadioButton
            // 
            this.refReturnsAndLocalsRadioButton.AutoSize = true;
            this.refReturnsAndLocalsRadioButton.Location = new System.Drawing.Point(17, 298);
            this.refReturnsAndLocalsRadioButton.Name = "refReturnsAndLocalsRadioButton";
            this.refReturnsAndLocalsRadioButton.Size = new System.Drawing.Size(153, 19);
            this.refReturnsAndLocalsRadioButton.TabIndex = 13;
            this.refReturnsAndLocalsRadioButton.TabStop = true;
            this.refReturnsAndLocalsRadioButton.Text = "Ref Returns and Locals";
            this.refReturnsAndLocalsRadioButton.UseVisualStyleBackColor = true;
            this.refReturnsAndLocalsRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // localFunctionsRadioButton
            // 
            this.localFunctionsRadioButton.AutoSize = true;
            this.localFunctionsRadioButton.Location = new System.Drawing.Point(17, 273);
            this.localFunctionsRadioButton.Name = "localFunctionsRadioButton";
            this.localFunctionsRadioButton.Size = new System.Drawing.Size(111, 19);
            this.localFunctionsRadioButton.TabIndex = 12;
            this.localFunctionsRadioButton.TabStop = true;
            this.localFunctionsRadioButton.Text = "Local Functions";
            this.localFunctionsRadioButton.UseVisualStyleBackColor = true;
            this.localFunctionsRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // deconstructionRadioButton
            // 
            this.deconstructionRadioButton.AutoSize = true;
            this.deconstructionRadioButton.Location = new System.Drawing.Point(17, 247);
            this.deconstructionRadioButton.Name = "deconstructionRadioButton";
            this.deconstructionRadioButton.Size = new System.Drawing.Size(107, 19);
            this.deconstructionRadioButton.TabIndex = 11;
            this.deconstructionRadioButton.TabStop = true;
            this.deconstructionRadioButton.Text = "Deconstruction";
            this.deconstructionRadioButton.UseVisualStyleBackColor = true;
            this.deconstructionRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // tuplesRadioButton
            // 
            this.tuplesRadioButton.AutoSize = true;
            this.tuplesRadioButton.Location = new System.Drawing.Point(17, 221);
            this.tuplesRadioButton.Name = "tuplesRadioButton";
            this.tuplesRadioButton.Size = new System.Drawing.Size(62, 19);
            this.tuplesRadioButton.TabIndex = 10;
            this.tuplesRadioButton.TabStop = true;
            this.tuplesRadioButton.Text = "Tuples";
            this.tuplesRadioButton.UseVisualStyleBackColor = true;
            this.tuplesRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // patternMatchingRadioButton
            // 
            this.patternMatchingRadioButton.AutoSize = true;
            this.patternMatchingRadioButton.Location = new System.Drawing.Point(17, 197);
            this.patternMatchingRadioButton.Name = "patternMatchingRadioButton";
            this.patternMatchingRadioButton.Size = new System.Drawing.Size(118, 19);
            this.patternMatchingRadioButton.TabIndex = 9;
            this.patternMatchingRadioButton.TabStop = true;
            this.patternMatchingRadioButton.Text = "Pattern Matching";
            this.patternMatchingRadioButton.UseVisualStyleBackColor = true;
            this.patternMatchingRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // outVariablesRadioButton
            // 
            this.outVariablesRadioButton.AutoSize = true;
            this.outVariablesRadioButton.Location = new System.Drawing.Point(17, 173);
            this.outVariablesRadioButton.Name = "outVariablesRadioButton";
            this.outVariablesRadioButton.Size = new System.Drawing.Size(98, 19);
            this.outVariablesRadioButton.TabIndex = 8;
            this.outVariablesRadioButton.TabStop = true;
            this.outVariablesRadioButton.Text = "Out Variables";
            this.outVariablesRadioButton.UseVisualStyleBackColor = true;
            this.outVariablesRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // awaitRadioButton
            // 
            this.awaitRadioButton.AutoSize = true;
            this.awaitRadioButton.Location = new System.Drawing.Point(17, 148);
            this.awaitRadioButton.Name = "awaitRadioButton";
            this.awaitRadioButton.Size = new System.Drawing.Size(140, 19);
            this.awaitRadioButton.TabIndex = 6;
            this.awaitRadioButton.TabStop = true;
            this.awaitRadioButton.Text = "\'await\' in Catch Block";
            this.awaitRadioButton.UseVisualStyleBackColor = true;
            this.awaitRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // exceptionFiltersRadioButton
            // 
            this.exceptionFiltersRadioButton.AutoSize = true;
            this.exceptionFiltersRadioButton.Location = new System.Drawing.Point(17, 125);
            this.exceptionFiltersRadioButton.Name = "exceptionFiltersRadioButton";
            this.exceptionFiltersRadioButton.Size = new System.Drawing.Size(115, 19);
            this.exceptionFiltersRadioButton.TabIndex = 5;
            this.exceptionFiltersRadioButton.TabStop = true;
            this.exceptionFiltersRadioButton.Text = "Exception Filters";
            this.exceptionFiltersRadioButton.UseVisualStyleBackColor = true;
            this.exceptionFiltersRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // nameofRadioButton
            // 
            this.nameofRadioButton.AutoSize = true;
            this.nameofRadioButton.Location = new System.Drawing.Point(17, 102);
            this.nameofRadioButton.Name = "nameofRadioButton";
            this.nameofRadioButton.Size = new System.Drawing.Size(206, 19);
            this.nameofRadioButton.TabIndex = 4;
            this.nameofRadioButton.TabStop = true;
            this.nameofRadioButton.Text = "\'nameof\' and Dictionary Initializer";
            this.nameofRadioButton.UseVisualStyleBackColor = true;
            this.nameofRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // expressionBodiedMembersRadioButton
            // 
            this.expressionBodiedMembersRadioButton.AutoSize = true;
            this.expressionBodiedMembersRadioButton.Location = new System.Drawing.Point(17, 78);
            this.expressionBodiedMembersRadioButton.Name = "expressionBodiedMembersRadioButton";
            this.expressionBodiedMembersRadioButton.Size = new System.Drawing.Size(184, 19);
            this.expressionBodiedMembersRadioButton.TabIndex = 3;
            this.expressionBodiedMembersRadioButton.TabStop = true;
            this.expressionBodiedMembersRadioButton.Text = "Expression-bodied Members";
            this.expressionBodiedMembersRadioButton.UseVisualStyleBackColor = true;
            this.expressionBodiedMembersRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // nullConditionalRadioButton
            // 
            this.nullConditionalRadioButton.AutoSize = true;
            this.nullConditionalRadioButton.Location = new System.Drawing.Point(17, 55);
            this.nullConditionalRadioButton.Name = "nullConditionalRadioButton";
            this.nullConditionalRadioButton.Size = new System.Drawing.Size(117, 19);
            this.nullConditionalRadioButton.TabIndex = 1;
            this.nullConditionalRadioButton.Text = "Null Propagation";
            this.nullConditionalRadioButton.UseVisualStyleBackColor = true;
            this.nullConditionalRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // stringInterpolationRadioButton
            // 
            this.stringInterpolationRadioButton.AutoSize = true;
            this.stringInterpolationRadioButton.Checked = true;
            this.stringInterpolationRadioButton.Location = new System.Drawing.Point(17, 32);
            this.stringInterpolationRadioButton.Name = "stringInterpolationRadioButton";
            this.stringInterpolationRadioButton.Size = new System.Drawing.Size(128, 19);
            this.stringInterpolationRadioButton.TabIndex = 0;
            this.stringInterpolationRadioButton.TabStop = true;
            this.stringInterpolationRadioButton.Text = "String Interpolation";
            this.stringInterpolationRadioButton.UseVisualStyleBackColor = true;
            this.stringInterpolationRadioButton.Click += new System.EventHandler(this.Stuff_Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(638, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 86);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // languageVersionPictureBox
            // 
            this.languageVersionPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("languageVersionPictureBox.BackgroundImage")));
            this.languageVersionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.languageVersionPictureBox.Location = new System.Drawing.Point(910, 12);
            this.languageVersionPictureBox.Name = "languageVersionPictureBox";
            this.languageVersionPictureBox.Size = new System.Drawing.Size(114, 86);
            this.languageVersionPictureBox.TabIndex = 6;
            this.languageVersionPictureBox.TabStop = false;
            // 
            // languageVersionPictureBox2
            // 
            this.languageVersionPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("languageVersionPictureBox2.BackgroundImage")));
            this.languageVersionPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.languageVersionPictureBox2.Location = new System.Drawing.Point(910, 12);
            this.languageVersionPictureBox2.Name = "languageVersionPictureBox2";
            this.languageVersionPictureBox2.Size = new System.Drawing.Size(114, 86);
            this.languageVersionPictureBox2.TabIndex = 7;
            this.languageVersionPictureBox2.TabStop = false;
            this.languageVersionPictureBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "https://github.com/amfuller81/January-2017-GCDNUG-Demo.git";
            // 
            // DemoChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1036, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageVersionPictureBox2);
            this.Controls.Add(this.languageVersionPictureBox);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageVersionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageVersionPictureBox2)).EndInit();
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
        private System.Windows.Forms.RadioButton expressionBodiedMembersRadioButton;
        private System.Windows.Forms.RadioButton nameofRadioButton;
        private System.Windows.Forms.RadioButton exceptionFiltersRadioButton;
        private System.Windows.Forms.RadioButton awaitRadioButton;
        private System.Windows.Forms.RadioButton outVariablesRadioButton;
        private System.Windows.Forms.RadioButton patternMatchingRadioButton;
        private System.Windows.Forms.RadioButton tuplesRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton deconstructionRadioButton;
        private System.Windows.Forms.RadioButton localFunctionsRadioButton;
        private System.Windows.Forms.PictureBox languageVersionPictureBox;
        private System.Windows.Forms.PictureBox languageVersionPictureBox2;
        private System.Windows.Forms.RadioButton refReturnsAndLocalsRadioButton;
        private System.Windows.Forms.Label label1;
    }
}

