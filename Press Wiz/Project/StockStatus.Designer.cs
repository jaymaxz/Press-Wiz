namespace Project
{
    partial class StockStatus
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
            this.pressWizDataSet = new Project.PressWizDataSet();
            this.page_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.page_StockTableAdapter = new Project.PressWizDataSetTableAdapters.Page_StockTableAdapter();
            this.tableAdapterManager = new Project.PressWizDataSetTableAdapters.TableAdapterManager();
            this.StockDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page_StockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).BeginInit();
            this.SuspendLayout();
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
            // StockDGV
            // 
            this.StockDGV.AutoGenerateColumns = false;
            this.StockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.StockDGV.DataSource = this.page_StockBindingSource;
            this.StockDGV.Location = new System.Drawing.Point(12, 12);
            this.StockDGV.Name = "StockDGV";
            this.StockDGV.Size = new System.Drawing.Size(300, 145);
            this.StockDGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Page_Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Page_Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "In_Stock";
            this.dataGridViewTextBoxColumn2.HeaderText = "In_Stock";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(79, 171);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(171, 171);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StockStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 206);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StockDGV);
            this.MaximizeBox = false;
            this.Name = "StockStatus";
            this.Text = "StockStatus";
            this.Load += new System.EventHandler(this.StockStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page_StockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PressWizDataSet pressWizDataSet;
        private System.Windows.Forms.BindingSource page_StockBindingSource;
        private PressWizDataSetTableAdapters.Page_StockTableAdapter page_StockTableAdapter;
        private PressWizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView StockDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
    }
}