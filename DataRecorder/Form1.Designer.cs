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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label2;
            this.disc_ch1 = new System.Windows.Forms.Button();
            this.com_ports_ch1 = new System.Windows.Forms.ComboBox();
            this.baud_rate_ch1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ch1_status = new System.Windows.Forms.Label();
            this.conn_ch1 = new System.Windows.Forms.Button();
            this.serialport_ch1 = new System.IO.Ports.SerialPort(this.components);
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
            this.ch2_status = new System.Windows.Forms.Label();
            this.ch3_status = new System.Windows.Forms.Label();
            this.ch4_status = new System.Windows.Forms.Label();
            this.ch5_status = new System.Windows.Forms.Label();
            this.ch6_status = new System.Windows.Forms.Label();
            this.ethernet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.eth_label = new System.Windows.Forms.Label();
            this.eth_port = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.disc_ch1);
            groupBox1.Controls.Add(this.com_ports_ch1);
            groupBox1.Controls.Add(this.baud_rate_ch1);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.ch1_status);
            groupBox1.Controls.Add(this.conn_ch1);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(218, 155);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial Port 1";
            // 
            // disc_ch1
            // 
            this.disc_ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc_ch1.Location = new System.Drawing.Point(115, 104);
            this.disc_ch1.Name = "disc_ch1";
            this.disc_ch1.Size = new System.Drawing.Size(85, 23);
            this.disc_ch1.TabIndex = 6;
            this.disc_ch1.Text = "Disconnect ";
            this.disc_ch1.UseVisualStyleBackColor = true;
            this.disc_ch1.Click += new System.EventHandler(this.disc_ch1_Click);
            // 
            // com_ports_ch1
            // 
            this.com_ports_ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ports_ch1.FormattingEnabled = true;
            this.com_ports_ch1.Location = new System.Drawing.Point(82, 33);
            this.com_ports_ch1.Name = "com_ports_ch1";
            this.com_ports_ch1.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch1.TabIndex = 0;

            // 
            // baud_rate_ch1
            // 
            this.baud_rate_ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.baud_rate_ch1.Location = new System.Drawing.Point(82, 63);
            this.baud_rate_ch1.Name = "baud_rate_ch1";
            this.baud_rate_ch1.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BAUD RATE:";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(9, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 13);
            label2.TabIndex = 3;
            label2.Text = "COM PORT:";
            // 
            // ch1_status
            // 
            this.ch1_status.AutoSize = true;
            this.ch1_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch1_status.Location = new System.Drawing.Point(9, 17);
            this.ch1_status.Name = "ch1_status";
            this.ch1_status.Size = new System.Drawing.Size(0, 13);
            this.ch1_status.TabIndex = 39;
            // 
            // conn_ch1
            // 
            this.conn_ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_ch1.Location = new System.Drawing.Point(12, 104);
            this.conn_ch1.Name = "conn_ch1";
            this.conn_ch1.Size = new System.Drawing.Size(85, 23);
            this.conn_ch1.TabIndex = 4;
            this.conn_ch1.Text = "Connect ";
            this.conn_ch1.UseVisualStyleBackColor = true;
            this.conn_ch1.Click += new System.EventHandler(this.conn_ch1_Click);
            // 
            // conn_ch2
            // 
            this.conn_ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_ch2.Location = new System.Drawing.Point(12, 104);
            this.conn_ch2.Name = "conn_ch2";
            this.conn_ch2.Size = new System.Drawing.Size(85, 23);
            this.conn_ch2.TabIndex = 7;
            this.conn_ch2.Text = "Connect";
            this.conn_ch2.UseVisualStyleBackColor = true;
            this.conn_ch2.Click += new System.EventHandler(this.conn_ch2_Click);
            // 
            // com_ports_ch2
            // 
            this.com_ports_ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ports_ch2.FormattingEnabled = true;
            this.com_ports_ch2.Location = new System.Drawing.Point(82, 33);
            this.com_ports_ch2.Name = "com_ports_ch2";
            this.com_ports_ch2.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch2.TabIndex = 8;
       
            // 
            // baud_rate_ch2
            // 
            this.baud_rate_ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.baud_rate_ch2.Location = new System.Drawing.Point(82, 63);
            this.baud_rate_ch2.Name = "baud_rate_ch2";
            this.baud_rate_ch2.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch2.TabIndex = 9;
            // 
            // disc_ch2
            // 
            this.disc_ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc_ch2.Location = new System.Drawing.Point(115, 104);
            this.disc_ch2.Name = "disc_ch2";
            this.disc_ch2.Size = new System.Drawing.Size(85, 23);
            this.disc_ch2.TabIndex = 11;
            this.disc_ch2.Text = "Disconnect";
            this.disc_ch2.UseVisualStyleBackColor = true;
            this.disc_ch2.Click += new System.EventHandler(this.disc_ch2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "COM PORT:";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "BAUD RATE:";
            // 
            // disc_ch3
            // 
            this.disc_ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc_ch3.Location = new System.Drawing.Point(115, 104);
            this.disc_ch3.Name = "disc_ch3";
            this.disc_ch3.Size = new System.Drawing.Size(85, 23);
            this.disc_ch3.TabIndex = 20;
            this.disc_ch3.Text = "Disconnect";
            this.disc_ch3.UseVisualStyleBackColor = true;
            this.disc_ch3.Click += new System.EventHandler(this.disc_ch3_Click);
            // 
            // conn_ch3
            // 
            this.conn_ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_ch3.Location = new System.Drawing.Point(12, 104);
            this.conn_ch3.Name = "conn_ch3";
            this.conn_ch3.Size = new System.Drawing.Size(85, 23);
            this.conn_ch3.TabIndex = 19;
            this.conn_ch3.Text = "Connect";
            this.conn_ch3.UseVisualStyleBackColor = true;
            this.conn_ch3.Click += new System.EventHandler(this.conn_ch3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "COM PORT:";
          
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "BAUD RATE:";
           
            // 
            // baud_rate_ch3
            // 
            this.baud_rate_ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.baud_rate_ch3.Location = new System.Drawing.Point(82, 63);
            this.baud_rate_ch3.Name = "baud_rate_ch3";
            this.baud_rate_ch3.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch3.TabIndex = 16;
            
            // 
            // com_ports_ch3
            // 
            this.com_ports_ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ports_ch3.FormattingEnabled = true;
            this.com_ports_ch3.Location = new System.Drawing.Point(82, 33);
            this.com_ports_ch3.Name = "com_ports_ch3";
            this.com_ports_ch3.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch3.TabIndex = 15;
      
            // 
            // disc_ch4
            // 
            this.disc_ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc_ch4.Location = new System.Drawing.Point(115, 104);
            this.disc_ch4.Name = "disc_ch4";
            this.disc_ch4.Size = new System.Drawing.Size(85, 23);
            this.disc_ch4.TabIndex = 26;
            this.disc_ch4.Text = "Disconnect";
            this.disc_ch4.UseVisualStyleBackColor = true;
            this.disc_ch4.Click += new System.EventHandler(this.disc_ch4_Click);
            // 
            // conn_ch4
            // 
            this.conn_ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_ch4.Location = new System.Drawing.Point(12, 104);
            this.conn_ch4.Name = "conn_ch4";
            this.conn_ch4.Size = new System.Drawing.Size(85, 23);
            this.conn_ch4.TabIndex = 25;
            this.conn_ch4.Text = "Connect";
            this.conn_ch4.UseVisualStyleBackColor = true;
            this.conn_ch4.Click += new System.EventHandler(this.conn_ch4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "COM PORT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "BAUD RATE:";
            // 
            // baud_rate_ch4
            // 
            this.baud_rate_ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.baud_rate_ch4.Location = new System.Drawing.Point(82, 63);
            this.baud_rate_ch4.Name = "baud_rate_ch4";
            this.baud_rate_ch4.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch4.TabIndex = 22;
        
            // 
            // com_ports_ch4
            // 
            this.com_ports_ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ports_ch4.FormattingEnabled = true;
            this.com_ports_ch4.Location = new System.Drawing.Point(82, 33);
            this.com_ports_ch4.Name = "com_ports_ch4";
            this.com_ports_ch4.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "BAUD RATE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "COM PORT:";
            // 
            // disc_ch5
            // 
            this.disc_ch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc_ch5.Location = new System.Drawing.Point(115, 104);
            this.disc_ch5.Name = "disc_ch5";
            this.disc_ch5.Size = new System.Drawing.Size(85, 23);
            this.disc_ch5.TabIndex = 30;
            this.disc_ch5.Text = "Disconnect";
            this.disc_ch5.UseVisualStyleBackColor = true;
            this.disc_ch5.Click += new System.EventHandler(this.disc_ch5_Click);
            // 
            // baud_rate_ch5
            // 
            this.baud_rate_ch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.baud_rate_ch5.Location = new System.Drawing.Point(82, 63);
            this.baud_rate_ch5.Name = "baud_rate_ch5";
            this.baud_rate_ch5.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch5.TabIndex = 29;
            // 
            // com_ports_ch5
            // 
            this.com_ports_ch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ports_ch5.FormattingEnabled = true;
            this.com_ports_ch5.Location = new System.Drawing.Point(82, 33);
            this.com_ports_ch5.Name = "com_ports_ch5";
            this.com_ports_ch5.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch5.TabIndex = 28;
            // 
            // conn_ch5
            // 
            this.conn_ch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_ch5.Location = new System.Drawing.Point(12, 104);
            this.conn_ch5.Name = "conn_ch5";
            this.conn_ch5.Size = new System.Drawing.Size(85, 23);
            this.conn_ch5.TabIndex = 27;
            this.conn_ch5.Text = "Connect";
            this.conn_ch5.UseVisualStyleBackColor = true;
            this.conn_ch5.Click += new System.EventHandler(this.conn_ch5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "BAUD RATE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "COM PORT:";
            // 
            // disc_ch6
            // 
            this.disc_ch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc_ch6.Location = new System.Drawing.Point(115, 104);
            this.disc_ch6.Name = "disc_ch6";
            this.disc_ch6.Size = new System.Drawing.Size(85, 23);
            this.disc_ch6.TabIndex = 36;
            this.disc_ch6.Text = "Disconnect ";
            this.disc_ch6.UseVisualStyleBackColor = true;
            this.disc_ch6.Click += new System.EventHandler(this.disc_ch6_Click);
            // 
            // baud_rate_ch6
            // 
            this.baud_rate_ch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.baud_rate_ch6.Location = new System.Drawing.Point(82, 63);
            this.baud_rate_ch6.Name = "baud_rate_ch6";
            this.baud_rate_ch6.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_ch6.TabIndex = 35;
            // 
            // com_ports_ch6
            // 
            this.com_ports_ch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ports_ch6.FormattingEnabled = true;
            this.com_ports_ch6.Location = new System.Drawing.Point(82, 33);
            this.com_ports_ch6.Name = "com_ports_ch6";
            this.com_ports_ch6.Size = new System.Drawing.Size(121, 21);
            this.com_ports_ch6.TabIndex = 34;
            // 
            // conn_ch6
            // 
            this.conn_ch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_ch6.Location = new System.Drawing.Point(12, 104);
            this.conn_ch6.Name = "conn_ch6";
            this.conn_ch6.Size = new System.Drawing.Size(85, 23);
            this.conn_ch6.TabIndex = 33;
            this.conn_ch6.Text = "Connect";
            this.conn_ch6.UseVisualStyleBackColor = true;
            this.conn_ch6.Click += new System.EventHandler(this.conn_ch6_Click);
            // 
            // ch2_status
            // 
            this.ch2_status.AutoSize = true;
            this.ch2_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch2_status.Location = new System.Drawing.Point(9, 18);
            this.ch2_status.Name = "ch2_status";
            this.ch2_status.Size = new System.Drawing.Size(0, 13);
            this.ch2_status.TabIndex = 40;
 
            // 
            // ch3_status
            // 
            this.ch3_status.AutoSize = true;
            this.ch3_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch3_status.Location = new System.Drawing.Point(9, 18);
            this.ch3_status.Name = "ch3_status";
            this.ch3_status.Size = new System.Drawing.Size(0, 13);
            this.ch3_status.TabIndex = 41;
  
            // 
            // ch4_status
            // 
            this.ch4_status.AutoSize = true;
            this.ch4_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch4_status.Location = new System.Drawing.Point(9, 18);
            this.ch4_status.Name = "ch4_status";
            this.ch4_status.Size = new System.Drawing.Size(0, 13);
            this.ch4_status.TabIndex = 42;
            // 
            // ch5_status
            // 
            this.ch5_status.AutoSize = true;
            this.ch5_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch5_status.Location = new System.Drawing.Point(9, 18);
            this.ch5_status.Name = "ch5_status";
            this.ch5_status.Size = new System.Drawing.Size(0, 13);
            this.ch5_status.TabIndex = 43;
            // 
            // ch6_status
            // 
            this.ch6_status.AutoSize = true;
            this.ch6_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch6_status.Location = new System.Drawing.Point(9, 18);
            this.ch6_status.Name = "ch6_status";
            this.ch6_status.Size = new System.Drawing.Size(0, 13);
            this.ch6_status.TabIndex = 44;
            // 
            // ethernet
            // 
            this.ethernet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethernet.Location = new System.Drawing.Point(246, 34);
            this.ethernet.Name = "ethernet";
            this.ethernet.Size = new System.Drawing.Size(85, 23);
            this.ethernet.TabIndex = 45;
            this.ethernet.Text = "Connect";
            this.ethernet.UseVisualStyleBackColor = true;
            this.ethernet.Click += new System.EventHandler(this.ethernet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disc_ch2);
            this.groupBox2.Controls.Add(this.conn_ch2);
            this.groupBox2.Controls.Add(this.com_ports_ch2);
            this.groupBox2.Controls.Add(this.baud_rate_ch2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ch2_status);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 155);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.com_ports_ch3);
            this.groupBox3.Controls.Add(this.baud_rate_ch3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.conn_ch3);
            this.groupBox3.Controls.Add(this.disc_ch3);
            this.groupBox3.Controls.Add(this.ch3_status);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 155);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial Port 3";

            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.disc_ch4);
            this.groupBox4.Controls.Add(this.com_ports_ch4);
            this.groupBox4.Controls.Add(this.baud_rate_ch4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.conn_ch4);
            this.groupBox4.Controls.Add(this.ch4_status);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(246, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 155);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial Port 4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.com_ports_ch5);
            this.groupBox5.Controls.Add(this.conn_ch5);
            this.groupBox5.Controls.Add(this.baud_rate_ch5);
            this.groupBox5.Controls.Add(this.disc_ch5);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.ch5_status);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(246, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 155);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serial Port 5";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.conn_ch6);
            this.groupBox6.Controls.Add(this.com_ports_ch6);
            this.groupBox6.Controls.Add(this.baud_rate_ch6);
            this.groupBox6.Controls.Add(this.disc_ch6);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.ch6_status);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(246, 336);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(218, 155);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Serial Port 6";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.eth_label);
            this.groupBox7.Controls.Add(this.eth_port);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.ethernet);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(12, 497);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(452, 83);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ethernet";
            // 
            // eth_label
            // 
            this.eth_label.AutoSize = true;
            this.eth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eth_label.Location = new System.Drawing.Point(9, 18);
            this.eth_label.Name = "eth_label";
            this.eth_label.Size = new System.Drawing.Size(0, 13);
            this.eth_label.TabIndex = 54;
            // 
            // eth_port
            // 
            this.eth_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eth_port.Location = new System.Drawing.Point(82, 34);
            this.eth_port.Name = "eth_port";
            this.eth_port.Size = new System.Drawing.Size(120, 20);
            this.eth_port.TabIndex = 54;
            this.eth_port.Text = "11111";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "PORT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 598);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "Form1";
            this.Text = "Data Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialport_ch1;
        private System.Windows.Forms.ComboBox com_ports_ch1;
        private System.Windows.Forms.ComboBox baud_rate_ch1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label ch2_status;
        private System.Windows.Forms.Label ch3_status;
        private System.Windows.Forms.Label ch4_status;
        private System.Windows.Forms.Label ch5_status;
        private System.Windows.Forms.Label ch6_status;
        private System.Windows.Forms.Button ethernet;
        private System.Windows.Forms.Label ch1_status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox eth_port;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label eth_label;
    }
}

