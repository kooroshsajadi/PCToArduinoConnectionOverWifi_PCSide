using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form2 : Form
    {
        private TcpClient tcpClient;
        public Form2(TcpClient tcpClient)
        {
            InitializeComponent();
            this.tcpClient = tcpClient;
        }

        private void LEDBtn1_Click(object sender, EventArgs e)
        {
            var str = LEDBtn1.Text == "turn on" ? "1on" : "1off";
            var isOnRequest = str.EndsWith("on") ? true : false;

            //Converting string to byte array
            byte[] bytesToSend = Encoding.ASCII.GetBytes(str);

            //Sending the byte array to the server
            tcpClient.Client.Send(bytesToSend);

            LEDBtn1.Text = isOnRequest ? "turn off" : "turn on";
            LEDPanel1.BackgroundImage = isOnRequest ? Properties.Resources.led_bulb_on : Properties.Resources.led_bulb_off;
        }

        private void LEDBtn2_Click(object sender, EventArgs e)
        {
            var str = LEDBtn2.Text == "turn on" ? "2on" : "2off";
            var isOnRequest = str.EndsWith("on") ? true : false;

            //Converting string to byte array
            byte[] bytesToSend = Encoding.ASCII.GetBytes(str);

            //Sending the byte array to the server
            tcpClient.Client.Send(bytesToSend);

            LEDBtn2.Text = isOnRequest ? "turn off" : "turn on";
            LEDPanel2.BackgroundImage = isOnRequest ? Properties.Resources.led_bulb_on : Properties.Resources.led_bulb_off;
        }

        private void LEDBtn3_Click(object sender, EventArgs e)
        {
            var str = LEDBtn3.Text == "turn on" ? "3on" : "3off";
            var isOnRequest = str.EndsWith("on") ? true : false;

            //Converting string to byte array
            byte[] bytesToSend = Encoding.ASCII.GetBytes(str);

            //Sending the byte array to the server
            tcpClient.Client.Send(bytesToSend);

            LEDBtn3.Text = isOnRequest ? "turn off" : "turn on";
            LEDPanel3.BackgroundImage = isOnRequest ? Properties.Resources.led_bulb_on : Properties.Resources.led_bulb_off;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
            {
                Owner.Close();
            }
        }
    }
}
