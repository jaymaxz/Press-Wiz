using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ReEnterPassword : Form
    {
        string First_Name;

        public ReEnterPassword(String First_Name)
        {
            InitializeComponent();
            this.First_Name = First_Name;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SqlConnection newConnection = new SqlConnection();
            newConnection.ConnectionString = "Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True";
            SqlCommand myCommand = new SqlCommand("SELECT * FROM [UserAccounts] WHERE First_Name = '" + First_Name + "' AND Password ='"+PWTextBox.Text+"';", newConnection);
            SqlDataReader myReader;
            try
            {
                newConnection.Open();
                myReader = myCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count++;
                }
                myReader.Close();
                newConnection.Close();
                if(count==1)
                {
                    ChangePW newChangePW = new ChangePW(First_Name);
                    this.Hide();
                    newChangePW.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password !", First_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PWTextBox.Focus();
                }
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.ToString(), "Connection Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OkButton.Focus();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "Connection Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OkButton.Focus();
            }
        }

        private void ReEnterPassword_Load(object sender, EventArgs e)
        {
            PWTextBox.Focus();
        }
    }
}
