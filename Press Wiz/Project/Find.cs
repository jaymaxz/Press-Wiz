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
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        User userj;

        internal User Userj
        {
            get { return userj; }
            set { userj = value; }
        }

        DatabaseConnection newConnection = new DatabaseConnection();

        private void FindButton_Click(object sender, EventArgs e)
        {
            userj = new User();
            userj = newConnection.findRow(UserIdTextBox.Text, FirstNameTextBox.Text,LastNameTextBox.Text);
            if (userj != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
