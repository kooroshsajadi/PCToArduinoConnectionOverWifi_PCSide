using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartClient()
        {
            try
            {
                var client = new TcpClient();

                //Connect to the server
                // darande   192.168.1.196
                //192.168.137.228
                var ip = System.Net.IPAddress.Parse("192.168.137.241");
                //192.168.1.196
                client.Connect(ip, 8080);
                var form2 = new Form2(client)
                {
                    Location = this.Location
                };
                form2.Show(this);

                //var str = "Hello world";

                ////Get the network stream
                //var stream = client.GetStream();

                ////Converting string to byte array
                //byte[] bytesToSend = Encoding.ASCII.GetBytes(str);

                ////Sending the byte array to the server
                //client.Client.Send(bytesToSend);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            StartClient();
            Hide();
        }
    }
}
