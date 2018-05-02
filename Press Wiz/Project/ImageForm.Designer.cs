namespace Project
{
    partial class ImageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Label();
            this.White = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Openbutton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "White %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Black %";
            // 
            // CalButton
            // 
            this.CalButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CalButton.Location = new System.Drawing.Point(317, 177);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(75, 23);
            this.CalButton.TabIndex = 3;
            this.CalButton.Text = "&Calculate";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(406, 177);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.Location = new System.Drawing.Point(376, 46);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(19, 13);
            this.Black.TabIndex = 6;
            this.Black.Text = "00";
            // 
            // White
            // 
            this.White.AutoSize = true;
            this.White.Location = new System.Drawing.Point(376, 80);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(19, 13);
            this.White.TabIndex = 5;
            this.White.Text = "00";
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(376, 116);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(19, 13);
            this.Colour.TabIndex = 8;
            this.Colour.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Colour %";
            // 
            // Openbutton
            // 
            this.Openbutton.Location = new System.Drawing.Point(226, 177);
            this.Openbutton.Name = "Openbutton";
            this.Openbutton.Size = new System.Drawing.Size(75, 23);
            this.Openbutton.TabIndex = 9;
            this.Openbutton.Text = "&Open";
            this.Openbutton.UseVisualStyleBackColor = true;
            this.Openbutton.Click += new System.EventHandler(this.Openbutton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.jpg|*.png|*.gif|*.bmp";
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(200, 200);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 234);
            this.Controls.Add(this.Openbutton);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.White);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture);
            this.MaximizeBox = false;
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Black;
        private System.Windows.Forms.Label White;
        private System.Windows.Forms.Label Colour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Openbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}