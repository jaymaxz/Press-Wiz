namespace Project
{
    partial class AddPages
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label page_TypeLabel;
            this.pressWizDataSet = new Project.PressWizDataSet();
            this.page_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.page_StockTableAdapter = new Project.PressWizDataSetTableAdapters.Page_StockTableAdapter();
            this.tableAdapterManager = new Project.PressWizDataSetTableAdapters.TableAdapterManager();
            this.PageTypeCombo = new System.Windows.Forms.ComboBox();
            this.pageStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NumberText = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            page_TypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page_StockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // page_TypeLabel
            // 
            page_TypeLabel.AutoSize = true;
            page_TypeLabel.Location = new System.Drawing.Point(92, 32);
            page_TypeLabel.Name = "page_TypeLabel";
            page_TypeLabel.Size = new System.Drawing.Size(62, 13);
            page_TypeLabel.TabIndex = 0;
            page_TypeLabel.Text = "Page Type:";
            // 
            // pressWizDataSet
            // 
            this.pressWizDataSet.DataSetName = "PressWizDataSet";
            this.pressWizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // page_StockBindingSource
            // 
            this.page_StockBindingSource.DataMember = "Page_Stock";
            this.page_StockBindingSource.DataSource = this.pressWizDataSet;
            // 
            // page_StockTableAdapter
            // 
            this.page_StockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Page_StockTableAdapter = this.page_StockTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.PressWizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAccountsTableAdapter = null;
            // 
            // PageTypeCombo
            // 
            this.PageTypeCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.page_StockBindingSource, "Page_Type", true));
            this.PageTypeCombo.DataSource = this.pageStockBindingSource;
            this.PageTypeCombo.DisplayMember = "Page_Type";
            this.PageTypeCombo.FormattingEnabled = true;
            this.PageTypeCombo.Location = new System.Drawing.Point(160, 29);
            this.PageTypeCombo.Name = "PageTypeCombo";
            this.PageTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.PageTypeCombo.TabIndex = 1;
            // 
            // pageStockBindingSource
            // 
            this.pageStockBindingSource.DataMember = "Page_Stock";
            this.pageStockBindingSource.DataSource = this.pressWizDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Bundles";
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(160, 70);
            this.NumberText.Mask = "00000";
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(121, 20);
            this.NumberText.TabIndex = 3;
            this.NumberText.Text = "10";
            this.NumberText.ValidatingType = typeof(int);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(79, 159);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(206, 159);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 207);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.label1);
            this.Controls.Add(page_TypeLabel);
            this.Controls.Add(this.PageTypeCombo);
            this.MinimizeBox = false;
            this.Name = "AddPages";
            this.Text = "AddPages";
            this.Load += new System.EventHandler(this.AddPages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page_StockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageStockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PressWizDataSet pressWizDataSet;
        private System.Windows.Forms.BindingSource page_StockBindingSource;
        private PressWizDataSetTableAdapters.Page_StockTableAdapter page_StockTableAdapter;
        private PressWizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox PageTypeCombo;
        private System.Windows.Forms.BindingSource pageStockBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox NumberText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
    }
}