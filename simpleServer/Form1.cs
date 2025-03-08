using System.Net;
using System.Net.Sockets;

namespace simpleServer
{
    public partial class Form1 : Form
    {
        private delegate void delUpdateUI(string sMessage);

        TcpListener m_server;
        Thread m_thrListening;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nPort = Convert.ToInt32(txtPort.Text); 
                IPAddress localAddr = IPAddress.Parse(txtIP.Text); 

                
                m_server = new TcpListener(localAddr, nPort);
                m_server.Start();
                m_thrListening = new Thread(Listening);
                m_thrListening.Start();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException: {0}", ex);
            }
        }

        private void Listening()
        {
            try
            {
                byte[] btDatas = new byte[256]; 
                string sData = null;

                while (true)
                {
                    UpdateStatus("Waiting for connection...");

                    TcpClient client = m_server.AcceptTcpClient(); 
                    UpdateStatus("Connect to client!");

                    sData = null;
                    NetworkStream stream = client.GetStream();

                    int i;
                    while ((i = stream.Read(btDatas, 0, btDatas.Length)) != 0) 
                    {
                        sData = System.Text.Encoding.ASCII.GetString(btDatas, 0, i);
                        UdpateMessage("Received Data:" + sData);
                        Thread.Sleep(5);
                    }

                    client.Close();
                    Thread.Sleep(5);
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException: {0}", ex);
            }
        }

        private void UpdateStatus(string sStatus)
        {
            if (this.InvokeRequired)
            {
                delUpdateUI del = new delUpdateUI(UpdateStatus);
                this.Invoke(del, sStatus);
            }
            else
            {
                StatusLab.Text = sStatus;
            }
        }

        private void UdpateMessage(string sReceiveData)
        {
            if (this.InvokeRequired)
            {
                delUpdateUI del = new delUpdateUI(UdpateMessage);
                this.Invoke(del, sReceiveData);
            }
            else
            {
                dataLog.Text += sReceiveData + Environment.NewLine;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
