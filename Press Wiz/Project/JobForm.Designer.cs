namespace Project
{
    partial class JobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobForm));
            this.PDFViewer = new AxAcroPDFLib.AxAcroPDF();
            this.OpenButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TotalPagesTextBox = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColourRadio = new System.Windows.Forms.RadioButton();
            this.BWRadio = new System.Windows.Forms.RadioButton();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PortraitRadio = new System.Windows.Forms.RadioButton();
            this.LandscapeRadio = new System.Windows.Forms.RadioButton();
            this.PageSizeCombo = new System.Windows.Forms.ComboBox();
            this.NoOfCopies = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFViewer
            // 
            this.PDFViewer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PDFViewer.Enabled = true;
            this.PDFViewer.Location = new System.Drawing.Point(12, 12);
            this.PDFViewer.Name = "PDFViewer";
            this.PDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFViewer.OcxState")));
            this.PDFViewer.Size = new System.Drawing.Size(418, 483);
            this.PDFViewer.TabIndex = 32;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(614, 30);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 33;
            this.OpenButton.Text = "&Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // TotalPagesTextBox
            // 
            this.TotalPagesTextBox.AutoSize = true;
            this.TotalPagesTextBox.Location = new System.Drawing.Point(612, 392);
            this.TotalPagesTextBox.Name = "TotalPagesTextBox";
            this.TotalPagesTextBox.Size = new System.Drawing.Size(108, 13);
            this.TotalPagesTextBox.TabIndex = 53;
            this.TotalPagesTextBox.Text = "Total no. of pages : 0";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.AutoSize = true;
            this.AmountTextBox.Location = new System.Drawing.Point(612, 418);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(104, 13);
            this.AmountTextBox.TabIndex = 52;
            this.AmountTextBox.Text = "Total Amount : Rs. 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColourRadio);
            this.groupBox2.Controls.Add(this.BWRadio);
            this.groupBox2.Location = new System.Drawing.Point(615, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 90);
            this.groupBox2.TabIndex = 51;
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
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(595, 82);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(103, 13);
            this.NumberLabel.TabIndex = 50;
            this.NumberLabel.Text = "Number of pages : 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortraitRadio);
            this.groupBox1.Controls.Add(this.LandscapeRadio);
            this.groupBox1.Location = new System.Drawing.Point(615, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 59);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orientation";
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
            // PageSizeCombo
            // 
            this.PageSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageSizeCombo.FormattingEnabled = true;
            this.PageSizeCombo.Items.AddRange(new object[] {
            "A4",
            "A3"});
            this.PageSizeCombo.Location = new System.Drawing.Point(694, 156);
            this.PageSizeCombo.Name = "PageSizeCombo";
            this.PageSizeCombo.Size = new System.Drawing.Size(121, 21);
            this.PageSizeCombo.TabIndex = 48;
            // 
            // NoOfCopies
            // 
            this.NoOfCopies.Location = new System.Drawing.Point(694, 119);
            this.NoOfCopies.Name = "NoOfCopies";
            this.NoOfCopies.Size = new System.Drawing.Size(120, 20);
            this.NoOfCopies.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Page Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Number Of Copies";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(694, 30);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 54;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(614, 458);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(139, 23);
            this.UpdateButton.TabIndex = 55;
            this.UpdateButton.Text = "Update to database";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 507);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalPagesTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageSizeCombo);
            this.Controls.Add(this.NoOfCopies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.PDFViewer);
            this.MaximizeBox = false;
            this.Name = "JobForm";
            this.Text = "JobForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.JobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDFViewer;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label TotalPagesTextBox;
        private System.Windows.Forms.Label AmountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ColourRadio;
        private System.Windows.Forms.RadioButton BWRadio;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PortraitRadio;
        private System.Windows.Forms.RadioButton LandscapeRadio;
        private System.Windows.Forms.ComboBox PageSizeCombo;
        private System.Windows.Forms.NumericUpDown NoOfCopies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}