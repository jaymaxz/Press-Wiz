using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Interop.Excel;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class CustomerMain : Form
    {
        public CustomerMain()
        {
            InitializeComponent();
        }

        string FileName;
        string Messege;
        int Number;
        int TotalPages;
        int TotalAmount;

        private void CustomerMain_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            FileName = "F:\\upload.pdf";
            NoOfCopies.UpButton();
            PageSizeCombo.SelectedIndex = 0;
            PortraitRadio.Select();
            BWRadio.Select();            
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout ?", "Press Wiz",
            MessageBoxButtons.YesNo) == DialogResult.No)
            {
                
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string ext = Path.GetExtension(file);
                if(ext==".doc"||ext==".docx")
                {
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Document doc = null;
                    doc = app.Documents.Open(file, Type.Missing, false);
                    doc.ExportAsFixedFormat(FileName, WdExportFormat.wdExportFormatPDF);
                    doc.Close(false, Type.Missing, Type.Missing);
                    app.Quit(false, false, false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                }
                if(ext=="pptx"||ext=="ppt")
                {
                    MessageBox.Show("Not Supported yet !", "Power Point", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(ext=="xlsx")
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

        private void genarateMsg()
        {
            string colourBW;
            string landPort;
            if(BWRadio.Checked)
            {
                colourBW = "BW";
            }
            else
            {
                colourBW = "colour";
            }
            if(LandscapeRadio.Checked)
            {
                landPort = "landscape"; 
            }
            else
            {
                landPort = "portrait"; 
            }
            Messege = NoOfCopies.Value.ToString() + "," + PageSizeCombo.SelectedItem.ToString() + "," + landPort + "," + colourBW + "," + TotalPages + "," + TotalAmount+",";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
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
        }

        private void SendButton_Click_1(object sender, EventArgs e)
        {
            CalculateButton.PerformClick();
            //send file
            Stream fileStream = File.OpenRead(FileName);
            // Alocate memory space for the file
            byte[] fileBuffer = new byte[fileStream.Length];
            fileStream.Read(fileBuffer, 0, (int)fileStream.Length);
            // Open a TCP/IP Connection and send the data
            TcpClient clientSocket = new TcpClient("localhost", 8080);
            NetworkStream networkStream = clientSocket.GetStream();
            networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
            networkStream.Close();
            //send messege
            UdpClient udpClient = new UdpClient();
            udpClient.Connect("localhost", 8080);
            genarateMsg();
            Byte[] sendBytes = Encoding.ASCII.GetBytes(Messege);
            udpClient.Send(sendBytes, sendBytes.Length);
        }
    }
}
