
namespace PracticeQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.trueRadioButton = new System.Windows.Forms.RadioButton();
            this.falseRadioButton = new System.Windows.Forms.RadioButton();
            this.trueFalseSubmitButton = new System.Windows.Forms.Button();
            this.trueFalseQuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(45, 30);
            this.questionLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(93, 15);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "QUIZ QUESTION";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 115);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 164);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(45, 212);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(45, 263);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(45, 316);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 19);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(45, 357);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(107, 44);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // trueRadioButton
            // 
            this.trueRadioButton.AutoSize = true;
            this.trueRadioButton.Location = new System.Drawing.Point(424, 254);
            this.trueRadioButton.Name = "trueRadioButton";
            this.trueRadioButton.Size = new System.Drawing.Size(47, 19);
            this.trueRadioButton.TabIndex = 7;
            this.trueRadioButton.TabStop = true;
            this.trueRadioButton.Text = "True";
            this.trueRadioButton.UseVisualStyleBackColor = true;
            // 
            // falseRadioButton
            // 
            this.falseRadioButton.AutoSize = true;
            this.falseRadioButton.Location = new System.Drawing.Point(424, 294);
            this.falseRadioButton.Name = "falseRadioButton";
            this.falseRadioButton.Size = new System.Drawing.Size(51, 19);
            this.falseRadioButton.TabIndex = 8;
            this.falseRadioButton.TabStop = true;
            this.falseRadioButton.Text = "False";
            this.falseRadioButton.UseVisualStyleBackColor = true;
            // 
            // trueFalseSubmitButton
            // 
            this.trueFalseSubmitButton.Location = new System.Drawing.Point(433, 335);
            this.trueFalseSubmitButton.Name = "trueFalseSubmitButton";
            this.trueFalseSubmitButton.Size = new System.Drawing.Size(75, 50);
            this.trueFalseSubmitButton.TabIndex = 9;
            this.trueFalseSubmitButton.Text = "Submit";
            this.trueFalseSubmitButton.UseVisualStyleBackColor = true;
            this.trueFalseSubmitButton.Click += new System.EventHandler(this.trueFalseSubmitButton_Click);
            // 
            // trueFalseQuestionLabel
            // 
            this.trueFalseQuestionLabel.AutoSize = true;
            this.trueFalseQuestionLabel.Location = new System.Drawing.Point(433, 181);
            this.trueFalseQuestionLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.trueFalseQuestionLabel.Name = "trueFalseQuestionLabel";
            this.trueFalseQuestionLabel.Size = new System.Drawing.Size(55, 15);
            this.trueFalseQuestionLabel.TabIndex = 10;
            this.trueFalseQuestionLabel.Text = "T/F Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.trueFalseQuestionLabel);
            this.Controls.Add(this.trueFalseSubmitButton);
            this.Controls.Add(this.falseRadioButton);
            this.Controls.Add(this.trueRadioButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton trueRadioButton;
        private System.Windows.Forms.RadioButton falseRadioButton;
        private System.Windows.Forms.Button trueFalseSubmitButton;
        private System.Windows.Forms.Label trueFalseQuestionLabel;
    }
}

