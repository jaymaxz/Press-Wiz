using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        IPHostEntry IPHost; //= Dns.GetHostByName(Dns.GetHostName());
        string hostName; //= IPHost.AddressList[0].ToString();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture(); 

        public Login()
        {
            InitializeComponent();
            IPHost = Dns.GetHostByName(Dns.GetHostName());
            hostName = IPHost.AddressList[0].ToString();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter User Name", "No input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UserIdTextBox.Focus();
            }
            else
            {
                if (PasswordTextBox.Text == "")
                {
                    MessageBox.Show("Please enter Password", "No input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PasswordTextBox.Focus();
                }
                else
                {
                    if (UserIdTextBox.Text == "/customer")
                    {
                        if (PasswordTextBox.Text == "customer")
                        {
                            //MessageBox.Show("customer", "customer");
                            CustomerMain cusMain = new CustomerMain();
                            this.Hide();
                            cusMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid password !", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PasswordTextBox.Text = "";
                            PasswordTextBox.Focus();
                        }
                    }
                    else
                    {
                        SqlConnection newConnection = new SqlConnection();
                        newConnection.ConnectionString = "Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True";
                        SqlCommand myCommand = new SqlCommand("SELECT * FROM [UserAccounts] WHERE UserId = '" + UserIdTextBox.Text + "' ", newConnection);
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
                            if (count == 1)
                            {
                                SqlCommand myCommand2 = new SqlCommand("SELECT * FROM [UserAccounts] WHERE admin = 1 AND UserId = '" + UserIdTextBox.Text + "' AND Password = '" + PasswordTextBox.Text + "'", newConnection);
                                SqlDataReader myReader2;
                                newConnection.Open();
                                myReader2 = myCommand2.ExecuteReader();
                                int count2 = 0;
                                string First_Name = "";
                                while (myReader2.Read())
                                {
                                    count2++;
                                    First_Name = (myReader2["First_Name"].ToString());
                                }
                                myReader2.Close();
                                newConnection.Close();
                                if (count2 == 1)
                                {
                                    SqlCommand myCommand21 = new SqlCommand("UPDATE UserAccounts SET ip ='"+hostName+"' WHERE admin = 1 AND UserId = '" + UserIdTextBox.Text + "' AND Password = '" + PasswordTextBox.Text + "'", newConnection);
                                    newConnection.Open();
                                    myCommand21.ExecuteNonQuery();
                                    newConnection.Close();
                                    //MessageBox.Show("admin", First_Name);
                                    if (PasswordTextBox.Text == "00000")
                                    {
                                        this.Hide();
                                        ChangePassword changePW = new ChangePassword(First_Name);
                                        changePW.Show();    
                                    }
                                    else
                                    {
                                        this.Hide();
                                        Main main = new Main(true, First_Name);
                                        main.Show();
                                    }
   
                                }
                                else
                                {
                                    SqlCommand myCommand3 = new SqlCommand("SELECT * FROM [UserAccounts] WHERE admin = 0 AND UserId = '" + UserIdTextBox.Text + "' AND Password = '" + PasswordTextBox.Text + "'", newConnection);
                                    SqlDataReader myReader3;
                                    newConnection.Open();
                                    myReader3 = myCommand3.ExecuteReader();
                                    int count3 = 0;
                                    while (myReader3.Read())
                                    {
                                        count3++;
                                        First_Name = (myReader3["First_Name"].ToString());
                                    }
                                    myReader3.Close();
                                    newConnection.Close();
                                    if (count3 == 1)
                                    {
                                        SqlCommand myCommand31 = new SqlCommand("UPDATE UserAccounts SET ip ='" + hostName + "' WHERE admin = 0 AND UserId = '" + UserIdTextBox.Text + "' AND Password = '" + PasswordTextBox.Text + "'", newConnection);
                                        newConnection.Open();
                                        myCommand31.ExecuteNonQuery();
                                        newConnection.Close();
                                        //MessageBox.Show("staff", First_Name);
                                        if (PasswordTextBox.Text == "00000")
                                        {
                                            this.Hide();
                                            ChangePassword changePW = new ChangePassword(First_Name);
                                            changePW.Show();
                                        }
                                        else
                                        {
                                            this.Hide();
                                            Main main = new Main(true, First_Name);
                                            main.Show();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        PasswordTextBox.Text = "";
                                        PasswordTextBox.Focus();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                UserIdTextBox.Text = "";
                                PasswordTextBox.Text = "";
                                UserIdTextBox.Focus();
                            }                   
                        }
                        catch(InvalidOperationException ioe)
                        {
                            MessageBox.Show(ioe.ToString(), "Connection Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoginButton.Focus();
                        }
                        catch(SqlException se)
                        {
                            MessageBox.Show(se.ToString(), "Connection Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoginButton.Focus();
                        }
                    }
                }
            }
        }

        private void UserNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                PasswordTextBox.Focus();
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                LoginButton.Focus();
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {              
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
