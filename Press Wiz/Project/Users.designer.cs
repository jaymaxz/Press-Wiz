namespace Project
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OnlineTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TelephoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.Location = new System.Drawing.Point(127, 140);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Enabled = false;
            this.FirstNameTextBox.Location = new System.Drawing.Point(127, 99);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(370, 316);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "&Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(208, 316);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "&Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(127, 316);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.Text = "&Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(127, 59);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(156, 20);
            this.UserIdTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telephone";
            // 
            // OnlineTextBox
            // 
            this.OnlineTextBox.Enabled = false;
            this.OnlineTextBox.Location = new System.Drawing.Point(127, 258);
            this.OnlineTextBox.Name = "OnlineTextBox";
            this.OnlineTextBox.Size = new System.Drawing.Size(156, 20);
            this.OnlineTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Online";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Admin";
            // 
            // TelephoneMTB
            // 
            this.TelephoneMTB.Location = new System.Drawing.Point(127, 177);
            this.TelephoneMTB.Mask = "0000000000";
            this.TelephoneMTB.Name = "TelephoneMTB";
            this.TelephoneMTB.Size = new System.Drawing.Size(156, 20);
            this.TelephoneMTB.TabIndex = 24;
            this.TelephoneMTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneMTB_KeyPress);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(127, 217);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AdminCheckBox.TabIndex = 25;
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            this.AdminCheckBox.Click += new System.EventHandler(this.AdminCheckBox_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(289, 316);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 26;
            this.FindButton.Text = "&Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(532, 316);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 27;
            this.NewButton.Text = "&New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(451, 316);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 28;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(771, 316);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.Text = "Clos&e";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UsersDGV
            // 
            this.UsersDGV.AllowUserToAddRows = false;
            this.UsersDGV.AllowUserToDeleteRows = false;
            this.UsersDGV.AllowUserToResizeColumns = false;
            this.UsersDGV.AllowUserToResizeRows = false;
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Location = new System.Drawing.Point(299, 59);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.Size = new System.Drawing.Size(733, 230);
            this.UsersDGV.TabIndex = 30;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(690, 316);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 31;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(609, 316);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 370);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UsersDGV);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.AdminCheckBox);
            this.Controls.Add(this.TelephoneMTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OnlineTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OnlineTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TelephoneMTB;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView UsersDGV;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;

    }
}