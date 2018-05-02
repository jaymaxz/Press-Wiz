using System;
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
    public partial class AddPages : Form
    {
        public AddPages()
        {
            InitializeComponent();
        }

        private void page_StockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.page_StockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pressWizDataSet);

        }

        private void AddPages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pressWizDataSet.Page_Stock' table. You can move, or remove it, as needed.
            this.page_StockTableAdapter.Fill(this.pressWizDataSet.Page_Stock);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            dbCon.addPages(PageTypeCombo.Text, 500*Int32.Parse(NumberText.Text));
            this.Close();
        }
    }
}
