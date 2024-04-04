using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Communication
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM4", 115200);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLiga_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
            }
            catch
            {
                Console.WriteLine("Unable to open COM PORT");
            }
            if (serialPort.IsOpen)
            {
                serialPort.Write("L");
            }
            serialPort.Close();

        }

        private void BtnDesliga_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
            }
            catch
            {
                Console.WriteLine("Unable to open COM PORT");
            }
            if (serialPort.IsOpen)
            {
                serialPort.Write("D");
            }
            serialPort.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
            }
            catch
            {
                Console.WriteLine("Unable to open COM PORT");
            }
            if (serialPort.IsOpen)
            {
                bool haveMessage = false;
                string message = string.Empty;

                while(!haveMessage)
                {
                    message = serialPort.ReadLine();
                    if(!string.IsNullOrEmpty(message))
                    {
                        haveMessage = true;
                    }
                    if(haveMessage)
                    {
                        textBox1.Text += message + Environment.NewLine;
                        serialPort.Close();
                    }
                }
                
            }
            serialPort.Close();
        }
    }
}
