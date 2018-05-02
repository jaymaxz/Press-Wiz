namespace Project
{
    partial class DailyReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyReportForm));
            this.pressWizDataSet = new Project.PressWizDataSet();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new Project.PressWizDataSetTableAdapters.ReportTableAdapter();
            this.tableAdapterManager = new Project.PressWizDataSetTableAdapters.TableAdapterManager();
            this.DailyReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
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
            // DailyReportViewer
            // 
            this.DailyReportViewer.ActiveViewIndex = -1;
            this.DailyReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DailyReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DailyReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DailyReportViewer.Name = "DailyReportViewer";
            this.DailyReportViewer.Size = new System.Drawing.Size(618, 392);
            this.DailyReportViewer.TabIndex = 0;
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 392);
            this.Controls.Add(this.DailyReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DailyReportForm";
            this.Text = "Daily Report";
            this.Load += new System.EventHandler(this.DailyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressWizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PressWizDataSet pressWizDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private PressWizDataSetTableAdapters.ReportTableAdapter reportTableAdapter;
        private PressWizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer DailyReportViewer;
    }
}