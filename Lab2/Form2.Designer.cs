namespace Lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label resultLabel;
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(138, 27);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(300, 26);
            this.inputTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(138, 97);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(300, 100);
            this.resultTextBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(201, 59);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(118, 31);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check Operators";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);

            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(30, 30);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(96, 20);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Input String:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(30, 100);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 20);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Operators:";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form2";
            this.Text = "Relational Operator Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}