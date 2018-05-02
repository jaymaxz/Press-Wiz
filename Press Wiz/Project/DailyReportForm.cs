﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DailyReportForm : Form
    {
        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pressWizDataSet.Report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.pressWizDataSet.Report);
            DailyReport dailyReport = new DailyReport();
            dailyReport.SetDataSource(this.pressWizDataSet);
            DailyReportViewer.ReportSource = dailyReport;
        }
    }
}
