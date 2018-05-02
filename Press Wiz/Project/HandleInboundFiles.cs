using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class HandleInboundFiles
    {
        private ArrayList alSockets;


        public HandleInboundFiles()
        {
            //IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            //lblStatus.Text = "My IP address is " + IPHost.AddressList[0].ToString();
            alSockets = new ArrayList();
            Thread thdListener = new Thread(new ThreadStart(listenerThread));
            thdListener.SetApartmentState(ApartmentState.STA);
            thdListener.Start();
            //
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.SetApartmentState(ApartmentState.STA);
            thdUDPServer.Start();
            //
        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                //lbConnections.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
                //MessageBox.Show(returnData.ToString(), "d");
                newJob(returnData.ToString());
            }
        }

        public void listenerThread()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 8080);
            tcpListener.Start();
            while (true)
            {
                Socket handlerSocket = tcpListener.AcceptSocket();
                if (handlerSocket.Connected)
                {
                    //lbConnections.Items.Add(handlerSocket.RemoteEndPoint.ToString() + " connected.");
                    lock (this)
                    {
                        alSockets.Add(handlerSocket);
                    }
                    ThreadStart thdstHandler = new ThreadStart(handlerThread);
                    Thread thdHandler = new Thread(thdstHandler);
                    thdHandler.SetApartmentState(ApartmentState.STA);
                    thdHandler.Start();
                }
            }
        }


        public void handlerThread()
        {
            Socket handlerSocket = (Socket)alSockets[alSockets.Count - 1];
            NetworkStream networkStream = new NetworkStream(handlerSocket);
            int thisRead = 0;
            int blockSize = 1024;
            Byte[] dataByte = new Byte[blockSize];
            lock (this)
            {
                // Only one process can access
                // the same file at any given time
                Stream fileStream = File.OpenWrite("f:\\download.pdf");
                while (true)
                {
                    thisRead = networkStream.Read(dataByte, 0, blockSize);
                    fileStream.Write(dataByte, 0, thisRead);
                    if (thisRead == 0) break;
                }
                fileStream.Close();
            }
            //lbConnections.Items.Add("File Written"); 
            handlerSocket = null;
        }

        public void newJob(string msg)
        {
            
            JobForm newjob = new JobForm(msg);
            newjob.ShowDialog();
        }
    }
}
