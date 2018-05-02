namespace Project
{
    partial class CustomerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.PDFViewer = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoOfCopies = new System.Windows.Forms.NumericUpDown();
            this.PageSizeCombo = new System.Windows.Forms.ComboBox();
            this.PortraitRadio = new System.Windows.Forms.RadioButton();
            this.LandscapeRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColourRadio = new System.Windows.Forms.RadioButton();
            this.BWRadio = new System.Windows.Forms.RadioButton();
            this.AmountTextBox = new System.Windows.Forms.Label();
            this.TotalPagesTextBox = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfCopies)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TimeLabel);
            this.panel2.Controls.Add(this.DateLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 770);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hello !";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Controls.Add(this.SendButton);
            this.panel1.Controls.Add(this.CalculateButton);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Location = new System.Drawing.Point(1266, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 770);
            this.panel1.TabIndex = 30;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.DarkGray;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Maroon;
            this.QuitButton.Image = global::Project.Properties.Resources.quit;
            this.QuitButton.Location = new System.Drawing.Point(0, 450);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(100, 100);
            this.QuitButton.TabIndex = 23;
            this.QuitButton.Text = "&Quit";
            this.QuitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DarkGray;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.Olive;
            this.SendButton.Image = global::Project.Properties.Resources.send;
            this.SendButton.Location = new System.Drawing.Point(0, 349);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 100);
            this.SendButton.TabIndex = 22;
            this.SendButton.Text = "&Send";
            this.SendButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click_1);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DarkGray;
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CalculateButton.Image = global::Project.Properties.Resources.calcculate;
            this.CalculateButton.Location = new System.Drawing.Point(0, 242);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 100);
            this.CalculateButton.TabIndex = 21;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.DarkGray;
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.OpenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.Color.Teal;
            this.OpenButton.Image = global::Project.Properties.Resources.open;
            this.OpenButton.Location = new System.Drawing.Point(0, 136);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(100, 100);
            this.OpenButton.TabIndex = 20;
            this.OpenButton.Text = "&Open";
            this.OpenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
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
            // PDFViewer
            // 
            this.PDFViewer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PDFViewer.Enabled = true;
            this.PDFViewer.Location = new System.Drawing.Point(222, 18);
            this.PDFViewer.Name = "PDFViewer";
            this.PDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFViewer.OcxState")));
            this.PDFViewer.Size = new System.Drawing.Size(633, 732);
            this.PDFViewer.TabIndex = 31;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(966, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Number Of Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1004, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Page Size";
            // 
            // NoOfCopies
            // 
            this.NoOfCopies.Location = new System.Drawing.Point(1065, 116);
            this.NoOfCopies.Name = "NoOfCopies";
            this.NoOfCopies.Size = new System.Drawing.Size(120, 20);
            this.NoOfCopies.TabIndex = 35;
            // 
            // PageSizeCombo
            // 
            this.PageSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageSizeCombo.FormattingEnabled = true;
            this.PageSizeCombo.Items.AddRange(new object[] {
            "A4",
            "A3"});
            this.PageSizeCombo.Location = new System.Drawing.Point(1065, 153);
            this.PageSizeCombo.Name = "PageSizeCombo";
            this.PageSizeCombo.Size = new System.Drawing.Size(121, 21);
            this.PageSizeCombo.TabIndex = 37;
            // 
            // PortraitRadio
            // 
            this.PortraitRadio.AutoSize = true;
            this.PortraitRadio.Location = new System.Drawing.Point(21, 27);
            this.PortraitRadio.Name = "PortraitRadio";
            this.PortraitRadio.Size = new System.Drawing.Size(58, 17);
            this.PortraitRadio.TabIndex = 38;
            this.PortraitRadio.TabStop = true;
            this.PortraitRadio.Text = "Portrait";
            this.PortraitRadio.UseVisualStyleBackColor = true;
            // 
            // LandscapeRadio
            // 
            this.LandscapeRadio.AutoSize = true;
            this.LandscapeRadio.Location = new System.Drawing.Point(96, 27);
            this.LandscapeRadio.Name = "LandscapeRadio";
            this.LandscapeRadio.Size = new System.Drawing.Size(78, 17);
            this.LandscapeRadio.TabIndex = 39;
            this.LandscapeRadio.TabStop = true;
            this.LandscapeRadio.Text = "Landscape";
            this.LandscapeRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortraitRadio);
            this.groupBox1.Controls.Add(this.LandscapeRadio);
            this.groupBox1.Location = new System.Drawing.Point(986, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 59);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orientation";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(966, 93);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(103, 13);
            this.NumberLabel.TabIndex = 41;
            this.NumberLabel.Text = "Number of pages : 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColourRadio);
            this.groupBox2.Controls.Add(this.BWRadio);
            this.groupBox2.Location = new System.Drawing.Point(986, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 90);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color or B/W";
            // 
            // ColourRadio
            // 
            this.ColourRadio.AutoSize = true;
            this.ColourRadio.Location = new System.Drawing.Point(21, 51);
            this.ColourRadio.Name = "ColourRadio";
            this.ColourRadio.Size = new System.Drawing.Size(55, 17);
            this.ColourRadio.TabIndex = 1;
            this.ColourRadio.TabStop = true;
            this.ColourRadio.Text = "Colour";
            this.ColourRadio.UseVisualStyleBackColor = true;
            // 
            // BWRadio
            // 
            this.BWRadio.AutoSize = true;
            this.BWRadio.Location = new System.Drawing.Point(21, 25);
            this.BWRadio.Name = "BWRadio";
            this.BWRadio.Size = new System.Drawing.Size(48, 17);
            this.BWRadio.TabIndex = 0;
            this.BWRadio.TabStop = true;
            this.BWRadio.Text = "B/W";
            this.BWRadio.UseVisualStyleBackColor = true;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.AutoSize = true;
            this.AmountTextBox.Location = new System.Drawing.Point(983, 415);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(104, 13);
            this.AmountTextBox.TabIndex = 43;
            this.AmountTextBox.Text = "Total Amount : Rs. 0";
            // 
            // TotalPagesTextBox
            // 
            this.TotalPagesTextBox.AutoSize = true;
            this.TotalPagesTextBox.Location = new System.Drawing.Point(983, 389);
            this.TotalPagesTextBox.Name = "TotalPagesTextBox";
            this.TotalPagesTextBox.Size = new System.Drawing.Size(108, 13);
            this.TotalPagesTextBox.TabIndex = 44;
            this.TotalPagesTextBox.Text = "Total no. of pages : 0";
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.TotalPagesTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageSizeCombo);
            this.Controls.Add(this.NoOfCopies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PDFViewer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerMain";
            this.Text = "CustomerMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfCopies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button QuitButton;
        private AxAcroPDFLib.AxAcroPDF PDFViewer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NoOfCopies;
        private System.Windows.Forms.ComboBox PageSizeCombo;
        private System.Windows.Forms.RadioButton PortraitRadio;
        private System.Windows.Forms.RadioButton LandscapeRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ColourRadio;
        private System.Windows.Forms.RadioButton BWRadio;
        private System.Windows.Forms.Label AmountTextBox;
        private System.Windows.Forms.Label TotalPagesTextBox;

    }
}