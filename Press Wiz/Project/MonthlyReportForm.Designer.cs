namespace Project
{
    partial class MonthlyReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReportForm));
            this.pressWizDataSet = new Project.PressWizDataSet();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new Project.PressWizDataSetTableAdapters.ReportTableAdapter();
            this.tableAdapterManager = new Project.PressWizDataSetTableAdapters.TableAdapterManager();
            this.MonthlyReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pressWizDataSet
            // 
            this.pressWizDataSet.DataSetName = "PressWizDataSet";
            this.pressWizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.pressWizDataSet;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Page_StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.PressWizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAccountsTableAdapter = null;
            // 
            // MonthlyReportViewer
            // 
            this.MonthlyReportViewer.ActiveViewIndex = -1;
            this.MonthlyReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthlyReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MonthlyReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MonthlyReportViewer.Name = "MonthlyReportViewer";
            this.MonthlyReportViewer.Size = new System.Drawing.Size(682, 441);
            this.MonthlyReportViewer.TabIndex = 0;
            // 
            // MonthlyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 441);
            this.Controls.Add(this.MonthlyReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonthlyReportForm";
            this.Text = "Monthly Report";
            this.Load += new System.EventHandler(this.MonthlyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PressWizDataSet pressWizDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private PressWizDataSetTableAdapters.ReportTableAdapter reportTableAdapter;
        private PressWizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer MonthlyReportViewer;

    }
}