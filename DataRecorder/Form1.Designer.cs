namespace DataRecorder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialport_ch1 = new System.IO.Ports.SerialPort(this.components);
            this.com_ports_ch1 = new System.Windows.Forms.ComboBox();
            this.baud_rate_ch1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conn_ch1 = new System.Windows.Forms.Button();
            this.disc_ch1 = new System.Windows.Forms.Button();
            this.conn_ch2 = new System.Windows.Forms.Button();
            this.com_ports_ch2 = new System.Windows.Forms.ComboBox();
            this.baud_rate_ch2 = new System.Windows.Forms.ComboBox();
            this.serialport_ch2 = new System.IO.Ports.SerialPort(this.components);
            this.disc_ch2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.disc_ch3 = new System.Windows.Forms.Button();
            this.conn_ch3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.baud_rate_ch3 = new System.Windows.Forms.ComboBox();
            this.com_ports_ch3 = new System.Windows.Forms.ComboBox();
            this.serialport_ch3 = new System.IO.Ports.SerialPort(this.components);
            this.disc_ch4 = new System.Windows.Forms.Button();
            this.conn_ch4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.baud_rate_ch4 = new System.Windows.Forms.ComboBox();
            this.com_ports_ch4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.disc_ch5 = new System.Windows.Forms.Button();
            this.baud_rate_ch5 = new System.Windows.Forms.ComboBox();
            this.com_ports_ch5 = new System.Windows.Forms.ComboBox();
            this.conn_ch5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.disc_ch6 = new System.Windows.Forms.Button();
            this.baud_rate_ch6 = new System.Windows.Forms.ComboBox();
            this.com_ports_ch6 = new System.Windows.Forms.ComboBox();
            this.conn_ch6 = new System.Windows.Forms.Button();
            this.serialport_ch4 = new System.IO.Ports.SerialPort(this.components);
            this.serialport_ch5 = new System.IO.Ports.SerialPort(this.components);
            this.serialport_ch6 = new System.IO.Ports.SerialPort(this.components);
            this.ch1_status = new System.Windows.Forms.Label();
            this.ch2_status = new System.Windows.Forms.Label();
            this.ch3_status = new System.Windows.Forms.Label();
            this.ch4_status = new System.Windows.Forms.Label();
            this.ch5_status = new System.Windows.Forms.Label();
            this.ch6_status = new System.Windows.Forms.Label();
            this.ethernet = new System.Windows.Forms.Button();
            this.data_ethernet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // com_ports_ch1
            // 
            this.com_ports_ch1.FormattingEnabled = true;
            this.com_ports_ch1.Location = new System.Drawing.Point(109, 33);
            this.com_ports_ch1.Name = "com_ports_ch1";
            this.com_ports_ch1.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch1.TabIndex = 0;
            this.com_ports_ch1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // baud_rate_ch1
            // 
            this.baud_rate_ch1.FormattingEnabled = true;
            this.baud_rate_ch1.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_ch1.Location = new System.Drawing.Point(109, 71);
            this.baud_rate_ch1.Name = "baud_rate_ch1";
            this.baud_rate_ch1.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate CH1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM PORT CH1";
            // 
            // conn_ch1
            // 
            this.conn_ch1.Location = new System.Drawing.Point(47, 107);
            this.conn_ch1.Name = "conn_ch1";
            this.conn_ch1.Size = new System.Drawing.Size(101, 23);
            this.conn_ch1.TabIndex = 4;
            this.conn_ch1.Text = "Connect CH1";
            this.conn_ch1.UseVisualStyleBackColor = true;
            this.conn_ch1.Click += new System.EventHandler(this.conn_ch1_Click);
            // 
            // disc_ch1
            // 
            this.disc_ch1.Location = new System.Drawing.Point(154, 107);
            this.disc_ch1.Name = "disc_ch1";
            this.disc_ch1.Size = new System.Drawing.Size(99, 23);
            this.disc_ch1.TabIndex = 6;
            this.disc_ch1.Text = "Disconnect CH1";
            this.disc_ch1.UseVisualStyleBackColor = true;
            this.disc_ch1.Click += new System.EventHandler(this.disc_ch1_Click);
            // 
            // conn_ch2
            // 
            this.conn_ch2.Location = new System.Drawing.Point(40, 261);
            this.conn_ch2.Name = "conn_ch2";
            this.conn_ch2.Size = new System.Drawing.Size(108, 23);
            this.conn_ch2.TabIndex = 7;
            this.conn_ch2.Text = "Connect CH2";
            this.conn_ch2.UseVisualStyleBackColor = true;
            this.conn_ch2.Click += new System.EventHandler(this.conn_ch2_Click);
            // 
            // com_ports_ch2
            // 
            this.com_ports_ch2.FormattingEnabled = true;
            this.com_ports_ch2.Location = new System.Drawing.Point(109, 169);
            this.com_ports_ch2.Name = "com_ports_ch2";
            this.com_ports_ch2.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch2.TabIndex = 8;
            // 
            // baud_rate_ch2
            // 
            this.baud_rate_ch2.FormattingEnabled = true;
            this.baud_rate_ch2.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_ch2.Location = new System.Drawing.Point(109, 210);
            this.baud_rate_ch2.Name = "baud_rate_ch2";
            this.baud_rate_ch2.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch2.TabIndex = 9;
            // 
            // disc_ch2
            // 
            this.disc_ch2.Location = new System.Drawing.Point(161, 261);
            this.disc_ch2.Name = "disc_ch2";
            this.disc_ch2.Size = new System.Drawing.Size(97, 23);
            this.disc_ch2.TabIndex = 11;
            this.disc_ch2.Text = "Disconnect CH2";
            this.disc_ch2.UseVisualStyleBackColor = true;
            this.disc_ch2.Click += new System.EventHandler(this.disc_ch2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "COM PORT CH2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Baud Rate CH2";
            // 
            // disc_ch3
            // 
            this.disc_ch3.Location = new System.Drawing.Point(154, 398);
            this.disc_ch3.Name = "disc_ch3";
            this.disc_ch3.Size = new System.Drawing.Size(99, 23);
            this.disc_ch3.TabIndex = 20;
            this.disc_ch3.Text = "Disconnect CH3";
            this.disc_ch3.UseVisualStyleBackColor = true;
            this.disc_ch3.Click += new System.EventHandler(this.disc_ch3_Click);
            // 
            // conn_ch3
            // 
            this.conn_ch3.Location = new System.Drawing.Point(47, 398);
            this.conn_ch3.Name = "conn_ch3";
            this.conn_ch3.Size = new System.Drawing.Size(101, 23);
            this.conn_ch3.TabIndex = 19;
            this.conn_ch3.Text = "Connect CH3";
            this.conn_ch3.UseVisualStyleBackColor = true;
            this.conn_ch3.Click += new System.EventHandler(this.conn_ch3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "COM PORT CH3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Baud Rate CH3";
            // 
            // baud_rate_ch3
            // 
            this.baud_rate_ch3.FormattingEnabled = true;
            this.baud_rate_ch3.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_ch3.Location = new System.Drawing.Point(109, 362);
            this.baud_rate_ch3.Name = "baud_rate_ch3";
            this.baud_rate_ch3.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch3.TabIndex = 16;
            // 
            // com_ports_ch3
            // 
            this.com_ports_ch3.FormattingEnabled = true;
            this.com_ports_ch3.Location = new System.Drawing.Point(109, 324);
            this.com_ports_ch3.Name = "com_ports_ch3";
            this.com_ports_ch3.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch3.TabIndex = 15;
            // 
            // disc_ch4
            // 
            this.disc_ch4.Location = new System.Drawing.Point(500, 102);
            this.disc_ch4.Name = "disc_ch4";
            this.disc_ch4.Size = new System.Drawing.Size(99, 23);
            this.disc_ch4.TabIndex = 26;
            this.disc_ch4.Text = "Disconnect CH4";
            this.disc_ch4.UseVisualStyleBackColor = true;
            this.disc_ch4.Click += new System.EventHandler(this.disc_ch4_Click);
            // 
            // conn_ch4
            // 
            this.conn_ch4.Location = new System.Drawing.Point(393, 102);
            this.conn_ch4.Name = "conn_ch4";
            this.conn_ch4.Size = new System.Drawing.Size(101, 23);
            this.conn_ch4.TabIndex = 25;
            this.conn_ch4.Text = "Connect CH4";
            this.conn_ch4.UseVisualStyleBackColor = true;
            this.conn_ch4.Click += new System.EventHandler(this.conn_ch4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "COM PORT CH4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Baud Rate CH4";
            // 
            // baud_rate_ch4
            // 
            this.baud_rate_ch4.FormattingEnabled = true;
            this.baud_rate_ch4.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_ch4.Location = new System.Drawing.Point(455, 66);
            this.baud_rate_ch4.Name = "baud_rate_ch4";
            this.baud_rate_ch4.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch4.TabIndex = 22;
            // 
            // com_ports_ch4
            // 
            this.com_ports_ch4.FormattingEnabled = true;
            this.com_ports_ch4.Location = new System.Drawing.Point(455, 28);
            this.com_ports_ch4.Name = "com_ports_ch4";
            this.com_ports_ch4.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Baud Rate CH5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "COM PORT CH5";
            // 
            // disc_ch5
            // 
            this.disc_ch5.Location = new System.Drawing.Point(503, 261);
            this.disc_ch5.Name = "disc_ch5";
            this.disc_ch5.Size = new System.Drawing.Size(97, 23);
            this.disc_ch5.TabIndex = 30;
            this.disc_ch5.Text = "Disconnect CH5";
            this.disc_ch5.UseVisualStyleBackColor = true;
            this.disc_ch5.Click += new System.EventHandler(this.disc_ch5_Click);
            // 
            // baud_rate_ch5
            // 
            this.baud_rate_ch5.FormattingEnabled = true;
            this.baud_rate_ch5.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_ch5.Location = new System.Drawing.Point(451, 210);
            this.baud_rate_ch5.Name = "baud_rate_ch5";
            this.baud_rate_ch5.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch5.TabIndex = 29;
            // 
            // com_ports_ch5
            // 
            this.com_ports_ch5.FormattingEnabled = true;
            this.com_ports_ch5.Location = new System.Drawing.Point(451, 169);
            this.com_ports_ch5.Name = "com_ports_ch5";
            this.com_ports_ch5.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch5.TabIndex = 28;
            // 
            // conn_ch5
            // 
            this.conn_ch5.Location = new System.Drawing.Point(382, 261);
            this.conn_ch5.Name = "conn_ch5";
            this.conn_ch5.Size = new System.Drawing.Size(108, 23);
            this.conn_ch5.TabIndex = 27;
            this.conn_ch5.Text = "Connect CH5";
            this.conn_ch5.UseVisualStyleBackColor = true;
            this.conn_ch5.Click += new System.EventHandler(this.conn_ch5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Baud Rate CH6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "COM PORT CH6";
            // 
            // disc_ch6
            // 
            this.disc_ch6.Location = new System.Drawing.Point(503, 412);
            this.disc_ch6.Name = "disc_ch6";
            this.disc_ch6.Size = new System.Drawing.Size(97, 23);
            this.disc_ch6.TabIndex = 36;
            this.disc_ch6.Text = "Disconnect CH6";
            this.disc_ch6.UseVisualStyleBackColor = true;
            this.disc_ch6.Click += new System.EventHandler(this.disc_ch6_Click);
            // 
            // baud_rate_ch6
            // 
            this.baud_rate_ch6.FormattingEnabled = true;
            this.baud_rate_ch6.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_ch6.Location = new System.Drawing.Point(451, 361);
            this.baud_rate_ch6.Name = "baud_rate_ch6";
            this.baud_rate_ch6.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch6.TabIndex = 35;
            // 
            // com_ports_ch6
            // 
            this.com_ports_ch6.FormattingEnabled = true;
            this.com_ports_ch6.Location = new System.Drawing.Point(451, 320);
            this.com_ports_ch6.Name = "com_ports_ch6";
            this.com_ports_ch6.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch6.TabIndex = 34;
            // 
            // conn_ch6
            // 
            this.conn_ch6.Location = new System.Drawing.Point(382, 412);
            this.conn_ch6.Name = "conn_ch6";
            this.conn_ch6.Size = new System.Drawing.Size(108, 23);
            this.conn_ch6.TabIndex = 33;
            this.conn_ch6.Text = "Connect CH6";
            this.conn_ch6.UseVisualStyleBackColor = true;
            this.conn_ch6.Click += new System.EventHandler(this.conn_ch6_Click);
            // 
            // ch1_status
            // 
            this.ch1_status.AutoSize = true;
            this.ch1_status.Location = new System.Drawing.Point(166, 17);
            this.ch1_status.Name = "ch1_status";
            this.ch1_status.Size = new System.Drawing.Size(64, 13);
            this.ch1_status.TabIndex = 39;
            this.ch1_status.Text = "Serial Port 1";
            // 
            // ch2_status
            // 
            this.ch2_status.AutoSize = true;
            this.ch2_status.Location = new System.Drawing.Point(166, 153);
            this.ch2_status.Name = "ch2_status";
            this.ch2_status.Size = new System.Drawing.Size(64, 13);
            this.ch2_status.TabIndex = 40;
            this.ch2_status.Text = "Serial Port 2";
            // 
            // ch3_status
            // 
            this.ch3_status.AutoSize = true;
            this.ch3_status.Location = new System.Drawing.Point(166, 308);
            this.ch3_status.Name = "ch3_status";
            this.ch3_status.Size = new System.Drawing.Size(64, 13);
            this.ch3_status.TabIndex = 41;
            this.ch3_status.Text = "Serial Port 3";
            // 
            // ch4_status
            // 
            this.ch4_status.AutoSize = true;
            this.ch4_status.Location = new System.Drawing.Point(512, 9);
            this.ch4_status.Name = "ch4_status";
            this.ch4_status.Size = new System.Drawing.Size(64, 13);
            this.ch4_status.TabIndex = 42;
            this.ch4_status.Text = "Serial Port 4";
            // 
            // ch5_status
            // 
            this.ch5_status.AutoSize = true;
            this.ch5_status.Location = new System.Drawing.Point(512, 153);
            this.ch5_status.Name = "ch5_status";
            this.ch5_status.Size = new System.Drawing.Size(64, 13);
            this.ch5_status.TabIndex = 43;
            this.ch5_status.Text = "Serial Port 5";
            // 
            // ch6_status
            // 
            this.ch6_status.AutoSize = true;
            this.ch6_status.Location = new System.Drawing.Point(512, 304);
            this.ch6_status.Name = "ch6_status";
            this.ch6_status.Size = new System.Drawing.Size(64, 13);
            this.ch6_status.TabIndex = 44;
            this.ch6_status.Text = "Serial Port 6";
            // 
            // ethernet
            // 
            this.ethernet.Location = new System.Drawing.Point(270, 492);
            this.ethernet.Name = "ethernet";
            this.ethernet.Size = new System.Drawing.Size(102, 23);
            this.ethernet.TabIndex = 45;
            this.ethernet.Text = "Ethernet";
            this.ethernet.UseVisualStyleBackColor = true;
            this.ethernet.Click += new System.EventHandler(this.ethernet_Click);
            // 
            // data_ethernet
            // 
            this.data_ethernet.Location = new System.Drawing.Point(40, 521);
            this.data_ethernet.Multiline = true;
            this.data_ethernet.Name = "data_ethernet";
            this.data_ethernet.Size = new System.Drawing.Size(579, 97);
            this.data_ethernet.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 643);
            this.Controls.Add(this.data_ethernet);
            this.Controls.Add(this.ethernet);
            this.Controls.Add(this.ch6_status);
            this.Controls.Add(this.ch5_status);
            this.Controls.Add(this.ch4_status);
            this.Controls.Add(this.ch3_status);
            this.Controls.Add(this.ch2_status);
            this.Controls.Add(this.ch1_status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.disc_ch6);
            this.Controls.Add(this.baud_rate_ch6);
            this.Controls.Add(this.com_ports_ch6);
            this.Controls.Add(this.conn_ch6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.disc_ch5);
            this.Controls.Add(this.baud_rate_ch5);
            this.Controls.Add(this.com_ports_ch5);
            this.Controls.Add(this.conn_ch5);
            this.Controls.Add(this.disc_ch4);
            this.Controls.Add(this.conn_ch4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.baud_rate_ch4);
            this.Controls.Add(this.com_ports_ch4);
            this.Controls.Add(this.disc_ch3);
            this.Controls.Add(this.conn_ch3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.baud_rate_ch3);
            this.Controls.Add(this.com_ports_ch3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.disc_ch2);
            this.Controls.Add(this.baud_rate_ch2);
            this.Controls.Add(this.com_ports_ch2);
            this.Controls.Add(this.conn_ch2);
            this.Controls.Add(this.disc_ch1);
            this.Controls.Add(this.conn_ch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baud_rate_ch1);
            this.Controls.Add(this.com_ports_ch1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialport_ch1;
        private System.Windows.Forms.ComboBox com_ports_ch1;
        private System.Windows.Forms.ComboBox baud_rate_ch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conn_ch1;
        private System.Windows.Forms.Button disc_ch1;
        private System.Windows.Forms.Button conn_ch2;
        private System.Windows.Forms.ComboBox com_ports_ch2;
        private System.Windows.Forms.ComboBox baud_rate_ch2;
        private System.IO.Ports.SerialPort serialport_ch2;
        private System.Windows.Forms.Button disc_ch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button disc_ch3;
        private System.Windows.Forms.Button conn_ch3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox baud_rate_ch3;
        private System.Windows.Forms.ComboBox com_ports_ch3;
        private System.IO.Ports.SerialPort serialport_ch3;
        private System.Windows.Forms.Button disc_ch4;
        private System.Windows.Forms.Button conn_ch4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox baud_rate_ch4;
        private System.Windows.Forms.ComboBox com_ports_ch4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button disc_ch5;
        private System.Windows.Forms.ComboBox baud_rate_ch5;
        private System.Windows.Forms.ComboBox com_ports_ch5;
        private System.Windows.Forms.Button conn_ch5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button disc_ch6;
        private System.Windows.Forms.ComboBox baud_rate_ch6;
        private System.Windows.Forms.ComboBox com_ports_ch6;
        private System.Windows.Forms.Button conn_ch6;
        private System.IO.Ports.SerialPort serialport_ch4;
        private System.IO.Ports.SerialPort serialport_ch5;
        private System.IO.Ports.SerialPort serialport_ch6;
        private System.Windows.Forms.Label ch1_status;
        private System.Windows.Forms.Label ch2_status;
        private System.Windows.Forms.Label ch3_status;
        private System.Windows.Forms.Label ch4_status;
        private System.Windows.Forms.Label ch5_status;
        private System.Windows.Forms.Label ch6_status;
        private System.Windows.Forms.Button ethernet;
        private System.Windows.Forms.TextBox data_ethernet;
    }
}

