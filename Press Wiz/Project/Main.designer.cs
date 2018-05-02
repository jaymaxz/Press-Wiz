namespace Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.DRButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.SSButton = new System.Windows.Forms.Button();
            this.ImageButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.CalculatorButton);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Location = new System.Drawing.Point(823, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 487);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.HelloLabel);
            this.panel2.Controls.Add(this.TimeLabel);
            this.panel2.Controls.Add(this.DateLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 488);
            this.panel2.TabIndex = 28;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.HelloLabel.Location = new System.Drawing.Point(23, 136);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(84, 17);
            this.HelloLabel.TabIndex = 31;
            this.HelloLabel.Text = "Hello, User !";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TimeLabel.Location = new System.Drawing.Point(23, 92);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(60, 17);
            this.TimeLabel.TabIndex = 30;
            this.TimeLabel.Text = "22:25:30";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DateLabel.Location = new System.Drawing.Point(23, 113);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(112, 17);
            this.DateLabel.TabIndex = 29;
            this.DateLabel.Text = "Friday, July 2016";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(124)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Press Wiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkGray;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logoutButton.Image = global::Project.Properties.Resources.logout;
            this.logoutButton.Location = new System.Drawing.Point(0, 349);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 100);
            this.logoutButton.TabIndex = 22;
            this.logoutButton.Text = "&Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.DarkGray;
            this.UserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.UserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UserButton.Image = global::Project.Properties.Resources.user;
            this.UserButton.Location = new System.Drawing.Point(0, 242);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(100, 100);
            this.UserButton.TabIndex = 21;
            this.UserButton.Text = "Use&r";
            this.UserButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UserButton.UseVisualStyleBackColor = false;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackColor = System.Drawing.Color.DarkGray;
            this.CalculatorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculatorButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.CalculatorButton.FlatAppearance.BorderSize = 0;
            this.CalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CalculatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CalculatorButton.Image = global::Project.Properties.Resources.Calculator;
            this.CalculatorButton.Location = new System.Drawing.Point(0, 136);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(100, 100);
            this.CalculatorButton.TabIndex = 20;
            this.CalculatorButton.Text = "&Calculator";
            this.CalculatorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalculatorButton.UseVisualStyleBackColor = false;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MinimizeButton.Image = global::Project.Properties.Resources.minimize;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.Location = new System.Drawing.Point(0, 30);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(100, 100);
            this.MinimizeButton.TabIndex = 19;
            this.MinimizeButton.Text = "&Minimize";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // DRButton
            // 
            this.DRButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DRButton.ForeColor = System.Drawing.Color.Navy;
            this.DRButton.Image = global::Project.Properties.Resources.daily;
            this.DRButton.Location = new System.Drawing.Point(434, 243);
            this.DRButton.Name = "DRButton";
            this.DRButton.Size = new System.Drawing.Size(160, 160);
            this.DRButton.TabIndex = 17;
            this.DRButton.Text = "&Daily Report";
            this.DRButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DRButton.UseVisualStyleBackColor = true;
            this.DRButton.Click += new System.EventHandler(this.DRButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.ForeColor = System.Drawing.Color.Teal;
            this.UsersButton.Image = global::Project.Properties.Resources.users;
            this.UsersButton.Location = new System.Drawing.Point(600, 243);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(160, 160);
            this.UsersButton.TabIndex = 18;
            this.UsersButton.Text = "&Users";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // MRButton
            // 
            this.MRButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MRButton.ForeColor = System.Drawing.Color.DarkRed;
            this.MRButton.Image = global::Project.Properties.Resources.monthly;
            this.MRButton.Location = new System.Drawing.Point(268, 243);
            this.MRButton.Name = "MRButton";
            this.MRButton.Size = new System.Drawing.Size(160, 160);
            this.MRButton.TabIndex = 16;
            this.MRButton.Text = "&Monthly Report";
            this.MRButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MRButton.UseVisualStyleBackColor = true;
            this.MRButton.Click += new System.EventHandler(this.MRButton_Click);
            // 
            // SSButton
            // 
            this.SSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SSButton.ForeColor = System.Drawing.Color.Green;
            this.SSButton.Image = global::Project.Properties.Resources.stock;
            this.SSButton.Location = new System.Drawing.Point(600, 77);
            this.SSButton.Name = "SSButton";
            this.SSButton.Size = new System.Drawing.Size(160, 160);
            this.SSButton.TabIndex = 15;
            this.SSButton.Text = "&Stock Status";
            this.SSButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SSButton.UseVisualStyleBackColor = true;
            this.SSButton.Click += new System.EventHandler(this.SSButton_Click);
            // 
            // ImageButton
            // 
            this.ImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButton.ForeColor = System.Drawing.Color.Purple;
            this.ImageButton.Image = global::Project.Properties.Resources.colour;
            this.ImageButton.Location = new System.Drawing.Point(434, 77);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(160, 160);
            this.ImageButton.TabIndex = 14;
            this.ImageButton.Text = "&Colour Precentage";
            this.ImageButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NewButton.Image = global::Project.Properties.Resources._new;
            this.NewButton.Location = new System.Drawing.Point(268, 77);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(160, 160);
            this.NewButton.TabIndex = 13;
            this.NewButton.Text = "&New Job";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(924, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DRButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.MRButton);
            this.Controls.Add(this.SSButton);
            this.Controls.Add(this.ImageButton);
            this.Controls.Add(this.NewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DRButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button SSButton;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label HelloLabel;


    }
}