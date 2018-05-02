using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.Net;
using System.Data.SqlClient;

namespace Project
{
    public partial class JobForm : Form
    {
        string Messege;
        string FileName;
        int Number;
        int TotalPages;
        int TotalAmount;
        string PageType;

        public JobForm(string messege)
        {
            InitializeComponent();
            this.Messege = messege;
            FileName = "f:\\download.pdf";
            OpenButton.Enabled = false;
            CalculateButton.Enabled = false;
            UpdateButton.Enabled = true;
            readMsg();
            PDFViewer.src = FileName;
        }

        public JobForm()
        {
            InitializeComponent();
            FileName = "f:\\toprint.pdf";
            NoOfCopies.UpButton();
            PageSizeCombo.SelectedIndex = 0;
            PortraitRadio.Select();
            BWRadio.Select();
            UpdateButton.Enabled = false;
        }

        private void JobForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string ext = Path.GetExtension(file);
                if (ext == ".doc" || ext == ".docx")
                {
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Document doc = null;
                    doc = app.Documents.Open(file, Type.Missing, false);
                    doc.ExportAsFixedFormat(FileName, WdExportFormat.wdExportFormatPDF);
                    doc.Close(false, Type.Missing, Type.Missing);
                    app.Quit(false, false, false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                }
                if (ext == "pptx" || ext == "ppt")
                {
                    MessageBox.Show("Not Supported yet !", "Power Point", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (ext == "xlsx")
                {
                    MessageBox.Show("Not Supported yet !", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                PDFViewer.src = FileName;
                using (StreamReader sr = new StreamReader(File.OpenRead(FileName)))
                {
                    Regex regex = new Regex(@"/Type\s*/Page[^s]");
                    MatchCollection matches = regex.Matches(sr.ReadToEnd());
                    Number = matches.Count;
                    NumberLabel.Text = "Number Of Pages : " + Number.ToString();
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            PageType = PageSizeCombo.SelectedItem.ToString();
            TotalPages = Number * Int32.Parse(NoOfCopies.Value.ToString());
            TotalPagesTextBox.Text = "Total no. of pages : " + TotalPages;
            if (PageSizeCombo.SelectedIndex == 0)
            {
                if (ColourRadio.Checked)
                {
                    TotalAmount = TotalPages * 20;
                }
                else
                {
                    TotalAmount = TotalPages * 4;
                }
            }
            else
            {
                if (ColourRadio.Checked)
                {
                    TotalAmount = TotalPages * 25;
                }
                else
                {
                    TotalAmount = TotalPages * 5;
                }
            }
            AmountTextBox.Text = "Total Amount : Rs " + TotalAmount;
            UpdateButton.Enabled = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CalculateButton.PerformClick();
            updateOrder();
        }

        public void readMsg()
        {
            int i= 0;
            string noOfCopies= "";
            string pageType = "";
            string landPort = "";
            string colourBW = "";
            string totalPages = "";
            string totalAmount = "";
            var msg = Messege.ToCharArray();
            while(msg[i]!=',')
            {
                noOfCopies = noOfCopies + msg[i];
                i++;
            }
            i++;
            NoOfCopies.Value = Int32.Parse(noOfCopies.ToString());
            while (msg[i] != ',')
            {
                pageType = pageType + msg[i];
                i++;
            }
            i++;
            PageType = pageType.ToString();
            PageSizeCombo.SelectedItem = PageType;
            while (msg[i] != ',')
            {
                landPort = landPort + msg[i];
                i++;
            }
            i++;
            if (landPort == "landscape")
            {
                LandscapeRadio.Checked = true;
            }
            else
            {
                PortraitRadio.Checked = true;
            }
            while (msg[i] != ',')
            {
                colourBW = colourBW + msg[i];
                i++;
            }
            i++;
            if (colourBW == "colour")
            {
                ColourRadio.Checked = true;
            }
            else
            {
                BWRadio.Checked = true;
            }
            while (msg[i] != ',')
            {
                totalPages = totalPages + msg[i];
                i++;
            }
            i++;
            TotalPages = Int32.Parse(totalPages);
            TotalPagesTextBox.Text = "Total no. of pages : " + TotalPages.ToString();
            while (msg[i] != ',')
            {
                totalAmount =  totalAmount + msg[i];
                i++;
            }
            i++;
            TotalAmount = Int32.Parse(totalAmount);
            AmountTextBox.Text = "Total Amount : Rs " + TotalAmount.ToString();
        }

        public void updateOrder()
        {
            string userId = getUserId();
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True";
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "INSERT INTO Orders(UserId,Date_Time,Page_Type,Number_Of_Pages,Amount) VALUES ('" + userId + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + PageType + "','" + TotalPages + "','" + TotalAmount + "');";
            try
            {
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

        public string getUserId()
        {
            IPHostEntry IPHost;
            string hostName; 
            IPHost = Dns.GetHostByName(Dns.GetHostName());
            hostName = IPHost.AddressList[0].ToString();
            SqlConnection newConnection = new SqlConnection();
            newConnection.ConnectionString = "Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True";
            SqlCommand myCommand2 = new SqlCommand("SELECT * FROM UserAccounts WHERE ip='"+hostName+"' ;", newConnection);
            SqlDataReader myReader2;
            newConnection.Open();
            myReader2 = myCommand2.ExecuteReader();
            int count2 = 0;
            string UserId = "";
            while (myReader2.Read())
            {
                count2++;
                UserId = (myReader2["UserId"].ToString());
            }
            newConnection.Close();
            return UserId;
        }
    }
}
