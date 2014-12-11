namespace TwoTimeApps
{
    partial class showTwoTimesTextBox
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
            this.aNumber = new System.Windows.Forms.Label();
            this.twoTimesValue = new System.Windows.Forms.Label();
            this.showTwoTimesButton = new System.Windows.Forms.Button();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.twoTimesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aNumber
            // 
            this.aNumber.AutoSize = true;
            this.aNumber.Location = new System.Drawing.Point(26, 61);
            this.aNumber.Name = "aNumber";
            this.aNumber.Size = new System.Drawing.Size(50, 13);
            this.aNumber.TabIndex = 0;
            this.aNumber.Text = "aNumber";
            this.aNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // twoTimesValue
            // 
            this.twoTimesValue.AutoSize = true;
            this.twoTimesValue.Location = new System.Drawing.Point(26, 107);
            this.twoTimesValue.Name = "twoTimesValue";
            this.twoTimesValue.Size = new System.Drawing.Size(89, 13);
            this.twoTimesValue.TabIndex = 1;
            this.twoTimesValue.Text = "Two Times Value";
            // 
            // showTwoTimesButton
            // 
            this.showTwoTimesButton.Location = new System.Drawing.Point(123, 172);
            this.showTwoTimesButton.Name = "showTwoTimesButton";
            this.showTwoTimesButton.Size = new System.Drawing.Size(120, 23);
            this.showTwoTimesButton.TabIndex = 2;
            this.showTwoTimesButton.Text = "Show Two Times";
            this.showTwoTimesButton.UseVisualStyleBackColor = true;
            this.showTwoTimesButton.Click += new System.EventHandler(this.showTwoTimesButton_Click);
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(143, 61);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.aNumberTextBox.TabIndex = 3;
            // 
            // twoTimesTextBox
            // 
            this.twoTimesTextBox.Location = new System.Drawing.Point(143, 100);
            this.twoTimesTextBox.Name = "twoTimesTextBox";
            this.twoTimesTextBox.Size = new System.Drawing.Size(100, 20);
            this.twoTimesTextBox.TabIndex = 4;
            // 
            // showTwoTimesTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.twoTimesTextBox);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.showTwoTimesButton);
            this.Controls.Add(this.twoTimesValue);
            this.Controls.Add(this.aNumber);
            this.Name = "showTwoTimesTextBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aNumber;
        private System.Windows.Forms.Label twoTimesValue;
        private System.Windows.Forms.Button showTwoTimesButton;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.TextBox twoTimesTextBox;
    }
}

