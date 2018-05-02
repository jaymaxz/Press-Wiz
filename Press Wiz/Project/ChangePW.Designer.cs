namespace Project
{
    partial class ChangePW
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
            this.ReTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PWTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReTextbox
            // 
            this.ReTextbox.Location = new System.Drawing.Point(148, 107);
            this.ReTextbox.MaxLength = 20;
            this.ReTextbox.Name = "ReTextbox";
            this.ReTextbox.Size = new System.Drawing.Size(100, 20);
            this.ReTextbox.TabIndex = 10;
            this.ReTextbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Retype Password";
            // 
            // PWTextBox
            // 
            this.PWTextBox.Location = new System.Drawing.Point(148, 50);
            this.PWTextBox.MaxLength = 20;
            this.PWTextBox.Name = "PWTextBox";
            this.PWTextBox.Size = new System.Drawing.Size(100, 20);
            this.PWTextBox.TabIndex = 8;
            this.PWTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter New Password";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(114, 188);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ReTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PWTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePW";
            this.Text = "ChangePW";
            this.Load += new System.EventHandler(this.ChangePW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PWTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
    }
}