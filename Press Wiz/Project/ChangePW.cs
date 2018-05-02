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
    public partial class ChangePW : Form
    {
        string First_Name;

        public ChangePW(string First_Name)
        {
            InitializeComponent();
            this.First_Name = First_Name;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(PWTextBox.Text == ""|| PWTextBox.Text.Length<6)
            {
                MessageBox.Show("Password cannot be null and must be longer than five Charactors", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PWTextBox.Text = "";
                ReTextbox.Text = "";
                PWTextBox.Focus();
            }
            else
            {
                if (ReTextbox.Text == "")
                {
                    MessageBox.Show("Re Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PWTextBox.Focus();
                }
                else
                {
                    if(PWTextBox.Text!=ReTextbox.Text)
                    {
                        MessageBox.Show("Passwords are mismatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PWTextBox.Text = "";
                        ReTextbox.Text = "";
                        PWTextBox.Focus();
                    }
                    else
                    {
                        SqlConnection myConnection = new SqlConnection("Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True");
                        SqlCommand myCommand = new SqlCommand();
                        myCommand.Connection = myConnection;
                        myCommand.CommandText = "UPDATE UserAccounts SET Password = '"+PWTextBox.Text+"' WHERE First_Name ='" + First_Name + "';";
                        try
                        {
                            myConnection.Open();
                            myCommand.ExecuteNonQuery();
                            myConnection.Close();
                        }

                        catch (InvalidCastException ice)
                        {
                            MessageBox.Show(ice.ToString());
                        }

                        catch (ObjectDisposedException ode)
                        {
                            MessageBox.Show(ode.ToString());

                        }

                        catch (SqlException se)
                        {
                            MessageBox.Show(se.ToString());

                        }

                        catch (InvalidOperationException ioe)
                        {
                            MessageBox.Show(ioe.ToString());

                        }
                        this.Close();
                    }
                    
                }
                
            } 
        }

        private void ChangePW_Load(object sender, EventArgs e)
        {
            PWTextBox.Focus();
        }
    }
}
