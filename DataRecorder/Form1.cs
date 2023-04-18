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
using System.IO;
using System.Net;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Reflection.Emit;

namespace DataRecorder
{
    public partial class Form1 : Form

    {
        // Folder path for the recorded text files. Replace with the data recorder PC path.
        string folder_path = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy");

        // UDP Client object
        UdpClient Client;

        // Serial  Text Files for 6 channels
        FileStream objStreamWriter_ch1;
        FileStream objStreamWriter_ch2;
        FileStream objStreamWriter_ch3;
        FileStream objStreamWriter_ch4;
        FileStream objStreamWriter_ch5;
        FileStream objStreamWriter_ch6;

        // UDP Text Files for 2 IPs
        FileStream objStreamWriter_eth1;
        FileStream objStreamWriter_eth2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Creating folder for the Text Files
            Directory.CreateDirectory(folder_path);
           

            //Get all the Serial Ports
            string[] ports = SerialPort.GetPortNames();
            int ser_ports = ports.GetLength(0);

            com_ports_ch1.Items.AddRange(ports);
            com_ports_ch2.Items.AddRange(ports);
            com_ports_ch3.Items.AddRange(ports);
            com_ports_ch4.Items.AddRange(ports);
            com_ports_ch5.Items.AddRange(ports);
            com_ports_ch6.Items.AddRange(ports);
            

            //com_ports_selection(ports.GetLength(0));
            baud_rate_selection();
            DialogResult obj = MessageBox.Show("Do you want to Edit Parameters?", "Exit", MessageBoxButtons.YesNo);
            if (obj == DialogResult.No)
            {
                conn_ch1.PerformClick();
                conn_ch2.PerformClick();
                conn_ch3.PerformClick();
                conn_ch4.PerformClick();
                conn_ch5.PerformClick();
                conn_ch6.PerformClick();
                ethernet.PerformClick();
            }
        }
        void recv(IAsyncResult res)
        {
            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);
            byte[] recieved_udp = Client.EndReceive(res, ref RemoteIP);

            objStreamWriter_eth1.Write(recieved_udp, 0, recieved_udp.Length);
            objStreamWriter_eth1.Flush();
            Client.BeginReceive(new AsyncCallback(recv), null);
        }
       
        private void conn_ch1_Click(object sender, EventArgs e)
        {
            try
            {
                serialport_ch1.PortName = com_ports_ch1.Text;
                serialport_ch1.BaudRate = Convert.ToInt32(baud_rate_ch1.Text);
                serialport_ch1.Parity = Parity.None;
                serialport_ch1.DataBits = 8;
                serialport_ch1.StopBits = StopBits.One;
                serialport_ch1.DataReceived += ch1_DataReceived;
                serialport_ch1.Open();
                if (serialport_ch1.IsOpen == true)
                {
                    ch1_status.Text = "Connected";
                    ch1_status.ForeColor = System.Drawing.Color.Green;
                    //Text File Location and Name
                    string pathfile_ch1 = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " COM1.txt";
                    objStreamWriter_ch1 = new FileStream(pathfile_ch1, FileMode.Create, FileAccess.Write);
                } 
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void conn_ch2_Click(object sender, EventArgs e)
        {
            try
            {
                serialport_ch2.PortName = com_ports_ch2.Text;
                serialport_ch2.BaudRate = Convert.ToInt32(baud_rate_ch2.Text);
                serialport_ch2.Parity = Parity.None;
                serialport_ch2.DataBits = 8;
                serialport_ch2.StopBits = StopBits.One;
                serialport_ch2.DataReceived += ch2_DataReceived;
                serialport_ch2.Open();
                if (serialport_ch2.IsOpen == true)
                {
                    ch2_status.Text = "Connected";
                    ch2_status.ForeColor = System.Drawing.Color.Green;
                    //Text File Location and Name
                    string pathfile_ch2 = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " COM2.txt";
                    objStreamWriter_ch2 = new FileStream(pathfile_ch2, FileMode.Create, FileAccess.Write);
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void conn_ch3_Click(object sender, EventArgs e)
        {
            try
            {
                serialport_ch3.PortName = com_ports_ch3.Text;
                serialport_ch3.BaudRate = Convert.ToInt32(baud_rate_ch3.Text);
                serialport_ch3.Parity = Parity.None;
                serialport_ch3.DataBits = 8;
                serialport_ch3.StopBits = StopBits.One;
                serialport_ch3.DataReceived += ch3_DataReceived;
                serialport_ch3.Open();
                if (serialport_ch3.IsOpen == true)
                {
                    ch3_status.Text = "Connected";
                    ch3_status.ForeColor = System.Drawing.Color.Green;
                    //Text File Location and Name
                    string pathfile_ch3 = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " COM3.txt";
                    objStreamWriter_ch3 = new FileStream(pathfile_ch3, FileMode.Create, FileAccess.Write);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void conn_ch4_Click(object sender, EventArgs e)
        {
            try
            {
                serialport_ch4.PortName = com_ports_ch4.Text;
                serialport_ch4.BaudRate = Convert.ToInt32(baud_rate_ch4.Text);
                serialport_ch4.Parity = Parity.None;
                serialport_ch4.DataBits = 8;
                serialport_ch4.StopBits = StopBits.One;
                serialport_ch4.DataReceived += ch4_DataReceived;
                serialport_ch4.Open();
                if (serialport_ch4.IsOpen == true)
                {
                    ch4_status.Text = "Connected";
                    ch4_status.ForeColor = System.Drawing.Color.Green;
                    //Text File Location and Name
                    string pathfile_ch4 = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " COM4.txt";
                    objStreamWriter_ch4 = new FileStream(pathfile_ch4, FileMode.Create, FileAccess.Write);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void conn_ch5_Click(object sender, EventArgs e)
        {
            try
            {
                serialport_ch5.PortName = com_ports_ch5.Text;
                serialport_ch5.BaudRate = Convert.ToInt32(baud_rate_ch5.Text);
                serialport_ch5.Parity = Parity.None;
                serialport_ch5.DataBits = 8;
                serialport_ch5.StopBits = StopBits.One;
                serialport_ch5.DataReceived += ch5_DataReceived;
                serialport_ch5.Open();
                if (serialport_ch5.IsOpen == true)
                {
                    ch5_status.Text = "Connected";
                    ch5_status.ForeColor = System.Drawing.Color.Green;
                    //Text File Location and Name
                    string pathfile_ch5 = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " COM5.txt";
                    objStreamWriter_ch5 = new FileStream(pathfile_ch5, FileMode.Create, FileAccess.Write);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void conn_ch6_Click(object sender, EventArgs e)
        {
            try
            {
                serialport_ch6.PortName = com_ports_ch6.Text;
                serialport_ch6.BaudRate = Convert.ToInt32(baud_rate_ch6.Text);
                serialport_ch6.Parity = Parity.None;
                serialport_ch6.DataBits = 8;
                serialport_ch6.StopBits = StopBits.One;
                serialport_ch6.DataReceived += ch6_DataReceived;
                serialport_ch6.Open();
                if (serialport_ch6.IsOpen == true)
                {
                    ch6_status.Text = "Connected";
                    ch6_status.ForeColor = System.Drawing.Color.Green;
                    //Text File Location and Name
                    string pathfile_ch6 = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " COM6.txt";
                    objStreamWriter_ch6 = new FileStream(pathfile_ch6, FileMode.Create, FileAccess.Write);
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ch1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count_ch1 = serialport_ch1.BytesToRead;
                byte[] data_ch1 = new byte[count_ch1];
                serialport_ch1.Read(data_ch1, 0, count_ch1);
                objStreamWriter_ch1.Write(data_ch1, 0, data_ch1.Length);
                objStreamWriter_ch1.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ch2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count_ch2 = serialport_ch2.BytesToRead;
                byte[] data_ch2 = new byte[count_ch2];
                serialport_ch2.Read(data_ch2, 0, count_ch2);
                objStreamWriter_ch2.Write(data_ch2, 0, data_ch2.Length);
                objStreamWriter_ch2.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ch3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count_ch3 = serialport_ch3.BytesToRead;
                byte[] data_ch3 = new byte[count_ch3];
                serialport_ch3.Read(data_ch3, 0, count_ch3);
                objStreamWriter_ch3.Write(data_ch3, 0, data_ch3.Length);
                objStreamWriter_ch3.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ch4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count_ch4 = serialport_ch4.BytesToRead;
                byte[] data_ch4 = new byte[count_ch4];
                serialport_ch4.Read(data_ch4, 0, count_ch4);
                objStreamWriter_ch4.Write(data_ch4, 0, data_ch4.Length);
                objStreamWriter_ch4.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ch5_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count_ch5 = serialport_ch5.BytesToRead;
                byte[] data_ch5 = new byte[count_ch5];
                serialport_ch5.Read(data_ch5, 0, count_ch5);
                objStreamWriter_ch5.Write(data_ch5, 0, data_ch5.Length);
                objStreamWriter_ch5.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ch6_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count_ch6 = serialport_ch6.BytesToRead;
                byte[] data_ch6 = new byte[count_ch6];
                serialport_ch6.Read(data_ch6, 0, count_ch6);
                objStreamWriter_ch6.Write(data_ch6, 0, data_ch6.Length);
                objStreamWriter_ch6.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }         
        private void disc_ch1_Click(object sender, EventArgs e)
        {
            if (serialport_ch1.IsOpen == true)
            {
                objStreamWriter_ch1.Close();
                serialport_ch1.Close();
                ch1_status.Text = "Disconnected";
                ch1_status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void disc_ch2_Click(object sender, EventArgs e)
        {
            if (serialport_ch2.IsOpen == true)
            {
                objStreamWriter_ch2.Close();
                serialport_ch2.Close();
                ch2_status.Text = "Disconnected";
                ch2_status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void disc_ch3_Click(object sender, EventArgs e)
        {
            if (serialport_ch3.IsOpen == true)
            {
                objStreamWriter_ch3.Close();
                serialport_ch3.Close();
                ch3_status.Text = "Disconnected";
                ch3_status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void disc_ch4_Click(object sender, EventArgs e)
        {
            if (serialport_ch4.IsOpen == true)
            {
                objStreamWriter_ch4.Close();
                serialport_ch4.Close();
                ch4_status.Text = "Disconnected";
                ch4_status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void disc_ch5_Click(object sender, EventArgs e)
        {
            if (serialport_ch5.IsOpen == true)
            {
                objStreamWriter_ch5.Close();
                serialport_ch5.Close();
                ch5_status.Text = "Disconnected";
                ch5_status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void disc_ch6_Click(object sender, EventArgs e)
        {
            if (serialport_ch6.IsOpen == true)
            {
                objStreamWriter_ch6.Close();
                serialport_ch6.Close();
                ch6_status.Text = "Disconnected";
                ch6_status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void ethernet_Click(object sender, EventArgs e)
        {
            try
            {
                string pathfile_ethernet = @"C:\Users\Hanzalah Qayyum\Desktop\" + DateTime.Now.ToString("dd-MM-yyyy") + "/" + DateTime.Now.ToString("HH.mm.ss") + " UDP.txt";
                objStreamWriter_eth1 = new FileStream(pathfile_ethernet, FileMode.Create, FileAccess.Write);
                Client = new UdpClient(Convert.ToInt32(eth_port.Text));  // Port Number
                Client.BeginReceive(new AsyncCallback(recv), null);
                eth_label.Text = "Connected";
                eth_label.ForeColor = System.Drawing.Color.Green;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        void baud_rate_selection()
        {
            // At 9 index the baud rate is 38400.
            baud_rate_ch1.SelectedIndex = 9;
            baud_rate_ch2.SelectedIndex = 9;
            baud_rate_ch3.SelectedIndex = 9;
            baud_rate_ch4.SelectedIndex = 9;
            baud_rate_ch5.SelectedIndex = 9;
            baud_rate_ch6.SelectedIndex = 9;
        }   
        void com_ports_selection(int total_ser_ports)
        {
            if (total_ser_ports > 0)
            {
                com_ports_ch1.SelectedIndex = 0;
                com_ports_ch2.SelectedIndex = 1;
                com_ports_ch3.SelectedIndex = 2;
                com_ports_ch4.SelectedIndex = 3;
                com_ports_ch5.SelectedIndex = 4;
                com_ports_ch6.SelectedIndex = 5;
            }
        }
    }
}
