using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private string First_Name;
        private bool Admin;

        public Main(bool Admin, string First_Name)
        {
            InitializeComponent();
            this.Admin = Admin;
            this.First_Name = First_Name;
            if(!Admin)
            {
                UsersButton.Enabled = false;
                SSButton.Enabled = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout ?", "Press Wiz",
            MessageBoxButtons.YesNo) == DialogResult.No)
            {
                    e.Cancel = true;
            }
            else
            {
            Application.Exit();
            SqlConnection newConnection = new SqlConnection();
            newConnection.ConnectionString = "Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True";
            SqlCommand myCommand21 = new SqlCommand("UPDATE UserAccounts SET ip ='" + null + "' WHERE First_Name = '" + First_Name + "';", newConnection);
            newConnection.Open();
            myCommand21.ExecuteNonQuery();
            newConnection.Close();
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("Taskkill /F /IM Project.vshost.exe");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("Taskkill /F /IM Project.exe");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HandleInboundFiles handleInboundFiles = new HandleInboundFiles();          
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            Timer tmr = new Timer();
            tmr.Interval = 1000; //ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            HelloLabel.Text = "Hello " + First_Name;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            ReEnterPassword newRePW = new ReEnterPassword(First_Name);
            newRePW.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            MonthlyReportForm monthlyRF = new MonthlyReportForm();
            monthlyRF.ShowDialog();
        }

        private void DRButton_Click(object sender, EventArgs e)
        {
            DailyReportForm dailyRF = new DailyReportForm();
            dailyRF.ShowDialog();
        }

        private void SSButton_Click(object sender, EventArgs e)
        {
            StockStatus stockStatus = new StockStatus();
            stockStatus.ShowDialog();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\system32\calc.exe";
            System.Diagnostics.Process.Start(path);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            JobForm newJob = new JobForm();
            newJob.ShowDialog();
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            ImageForm imgFrm = new ImageForm();
            imgFrm.Show();
        }
    }
}
