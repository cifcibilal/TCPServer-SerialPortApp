namespace TCPServer_SerialPortApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGidenPort2 = new System.Windows.Forms.TextBox();
            this.btnGonderPort2 = new System.Windows.Forms.Button();
            this.btnSilPort2 = new System.Windows.Forms.Button();
            this.txtGelenPort2 = new System.Windows.Forms.TextBox();
            this.btnBaglantiKesPort2 = new System.Windows.Forms.Button();
            this.btnBaglanPort2 = new System.Windows.Forms.Button();
            this.comboBoxPorts2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGidenPort = new System.Windows.Forms.TextBox();
            this.btnGonderPort = new System.Windows.Forms.Button();
            this.btnSilPort = new System.Windows.Forms.Button();
            this.txtGelenPort = new System.Windows.Forms.TextBox();
            this.btnBaglantiKesPort = new System.Windows.Forms.Button();
            this.btnBaglanPort = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtGonderilenMesaj = new System.Windows.Forms.TextBox();
            this.txtGelenMesaj = new System.Windows.Forms.TextBox();
            this.btnAyril = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGonderClient = new System.Windows.Forms.Button();
            this.txtGonderilenClient = new System.Windows.Forms.TextBox();
            this.txtGelenClient = new System.Windows.Forms.TextBox();
            this.btnBaglanClient = new System.Windows.Forms.Button();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.btnAyrilClient = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 452);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(737, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SerialPort";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGidenPort2);
            this.groupBox2.Controls.Add(this.btnGonderPort2);
            this.groupBox2.Controls.Add(this.btnSilPort2);
            this.groupBox2.Controls.Add(this.txtGelenPort2);
            this.groupBox2.Controls.Add(this.btnBaglantiKesPort2);
            this.groupBox2.Controls.Add(this.btnBaglanPort2);
            this.groupBox2.Controls.Add(this.comboBoxPorts2);
            this.groupBox2.Location = new System.Drawing.Point(371, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(353, 407);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtGidenPort2
            // 
            this.txtGidenPort2.Location = new System.Drawing.Point(8, 319);
            this.txtGidenPort2.Margin = new System.Windows.Forms.Padding(4);
            this.txtGidenPort2.Multiline = true;
            this.txtGidenPort2.Name = "txtGidenPort2";
            this.txtGidenPort2.Size = new System.Drawing.Size(227, 80);
            this.txtGidenPort2.TabIndex = 6;
            // 
            // btnGonderPort2
            // 
            this.btnGonderPort2.Location = new System.Drawing.Point(244, 319);
            this.btnGonderPort2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonderPort2.Name = "btnGonderPort2";
            this.btnGonderPort2.Size = new System.Drawing.Size(100, 37);
            this.btnGonderPort2.TabIndex = 5;
            this.btnGonderPort2.Text = "Gönder";
            this.btnGonderPort2.UseVisualStyleBackColor = true;
            this.btnGonderPort2.Click += new System.EventHandler(this.btnGonderPort2_Click);
            // 
            // btnSilPort2
            // 
            this.btnSilPort2.Location = new System.Drawing.Point(244, 363);
            this.btnSilPort2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSilPort2.Name = "btnSilPort2";
            this.btnSilPort2.Size = new System.Drawing.Size(100, 37);
            this.btnSilPort2.TabIndex = 4;
            this.btnSilPort2.Text = "Yazı Sil";
            this.btnSilPort2.UseVisualStyleBackColor = true;
            this.btnSilPort2.Click += new System.EventHandler(this.btnSilPort2_Click);
            // 
            // txtGelenPort2
            // 
            this.txtGelenPort2.Location = new System.Drawing.Point(8, 55);
            this.txtGelenPort2.Margin = new System.Windows.Forms.Padding(4);
            this.txtGelenPort2.Multiline = true;
            this.txtGelenPort2.Name = "txtGelenPort2";
            this.txtGelenPort2.Size = new System.Drawing.Size(335, 255);
            this.txtGelenPort2.TabIndex = 3;
            // 
            // btnBaglantiKesPort2
            // 
            this.btnBaglantiKesPort2.Location = new System.Drawing.Point(244, 11);
            this.btnBaglantiKesPort2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglantiKesPort2.Name = "btnBaglantiKesPort2";
            this.btnBaglantiKesPort2.Size = new System.Drawing.Size(100, 37);
            this.btnBaglantiKesPort2.TabIndex = 2;
            this.btnBaglantiKesPort2.Text = "Bağlantı Kes";
            this.btnBaglantiKesPort2.UseVisualStyleBackColor = true;
            this.btnBaglantiKesPort2.Click += new System.EventHandler(this.btnBaglantiKesPort2_Click);
            // 
            // btnBaglanPort2
            // 
            this.btnBaglanPort2.Location = new System.Drawing.Point(136, 11);
            this.btnBaglanPort2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglanPort2.Name = "btnBaglanPort2";
            this.btnBaglanPort2.Size = new System.Drawing.Size(100, 37);
            this.btnBaglanPort2.TabIndex = 1;
            this.btnBaglanPort2.Text = "Bağlan";
            this.btnBaglanPort2.UseVisualStyleBackColor = true;
            this.btnBaglanPort2.Click += new System.EventHandler(this.btnBaglanPort2_Click);
            // 
            // comboBoxPorts2
            // 
            this.comboBoxPorts2.FormattingEnabled = true;
            this.comboBoxPorts2.Location = new System.Drawing.Point(8, 18);
            this.comboBoxPorts2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(119, 24);
            this.comboBoxPorts2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGidenPort);
            this.groupBox1.Controls.Add(this.btnGonderPort);
            this.groupBox1.Controls.Add(this.btnSilPort);
            this.groupBox1.Controls.Add(this.txtGelenPort);
            this.groupBox1.Controls.Add(this.btnBaglantiKesPort);
            this.groupBox1.Controls.Add(this.btnBaglanPort);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(353, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtGidenPort
            // 
            this.txtGidenPort.Location = new System.Drawing.Point(8, 319);
            this.txtGidenPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtGidenPort.Multiline = true;
            this.txtGidenPort.Name = "txtGidenPort";
            this.txtGidenPort.Size = new System.Drawing.Size(227, 80);
            this.txtGidenPort.TabIndex = 6;
            // 
            // btnGonderPort
            // 
            this.btnGonderPort.Location = new System.Drawing.Point(244, 319);
            this.btnGonderPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonderPort.Name = "btnGonderPort";
            this.btnGonderPort.Size = new System.Drawing.Size(100, 37);
            this.btnGonderPort.TabIndex = 5;
            this.btnGonderPort.Text = "Gönder";
            this.btnGonderPort.UseVisualStyleBackColor = true;
            this.btnGonderPort.Click += new System.EventHandler(this.btnGonderPort_Click);
            // 
            // btnSilPort
            // 
            this.btnSilPort.Location = new System.Drawing.Point(244, 363);
            this.btnSilPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSilPort.Name = "btnSilPort";
            this.btnSilPort.Size = new System.Drawing.Size(100, 37);
            this.btnSilPort.TabIndex = 4;
            this.btnSilPort.Text = "Yazı Sil";
            this.btnSilPort.UseVisualStyleBackColor = true;
            this.btnSilPort.Click += new System.EventHandler(this.btnSilPort_Click);
            // 
            // txtGelenPort
            // 
            this.txtGelenPort.Location = new System.Drawing.Point(8, 55);
            this.txtGelenPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtGelenPort.Multiline = true;
            this.txtGelenPort.Name = "txtGelenPort";
            this.txtGelenPort.Size = new System.Drawing.Size(335, 255);
            this.txtGelenPort.TabIndex = 3;
            // 
            // btnBaglantiKesPort
            // 
            this.btnBaglantiKesPort.Location = new System.Drawing.Point(244, 11);
            this.btnBaglantiKesPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglantiKesPort.Name = "btnBaglantiKesPort";
            this.btnBaglantiKesPort.Size = new System.Drawing.Size(100, 37);
            this.btnBaglantiKesPort.TabIndex = 2;
            this.btnBaglantiKesPort.Text = "Bağlantı Kes";
            this.btnBaglantiKesPort.UseVisualStyleBackColor = true;
            this.btnBaglantiKesPort.Click += new System.EventHandler(this.btnBaglantiKesPort_Click);
            // 
            // btnBaglanPort
            // 
            this.btnBaglanPort.Location = new System.Drawing.Point(136, 11);
            this.btnBaglanPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglanPort.Name = "btnBaglanPort";
            this.btnBaglanPort.Size = new System.Drawing.Size(100, 37);
            this.btnBaglanPort.TabIndex = 1;
            this.btnBaglanPort.Text = "Bağlan";
            this.btnBaglanPort.UseVisualStyleBackColor = true;
            this.btnBaglanPort.Click += new System.EventHandler(this.btnBaglanPort_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(8, 18);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(119, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnGonder);
            this.tabPage2.Controls.Add(this.txtGonderilenMesaj);
            this.tabPage2.Controls.Add(this.txtGelenMesaj);
            this.tabPage2.Controls.Add(this.btnAyril);
            this.tabPage2.Controls.Add(this.btnBaglan);
            this.tabPage2.Controls.Add(this.txtPort);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtIP);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(737, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP/Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(591, 347);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(123, 60);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtGonderilenMesaj
            // 
            this.txtGonderilenMesaj.Location = new System.Drawing.Point(23, 347);
            this.txtGonderilenMesaj.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderilenMesaj.Multiline = true;
            this.txtGonderilenMesaj.Name = "txtGonderilenMesaj";
            this.txtGonderilenMesaj.Size = new System.Drawing.Size(547, 59);
            this.txtGonderilenMesaj.TabIndex = 7;
            // 
            // txtGelenMesaj
            // 
            this.txtGelenMesaj.Location = new System.Drawing.Point(23, 62);
            this.txtGelenMesaj.Margin = new System.Windows.Forms.Padding(4);
            this.txtGelenMesaj.Multiline = true;
            this.txtGelenMesaj.Name = "txtGelenMesaj";
            this.txtGelenMesaj.Size = new System.Drawing.Size(689, 277);
            this.txtGelenMesaj.TabIndex = 6;
            // 
            // btnAyril
            // 
            this.btnAyril.Location = new System.Drawing.Point(591, 10);
            this.btnAyril.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyril.Name = "btnAyril";
            this.btnAyril.Size = new System.Drawing.Size(123, 34);
            this.btnAyril.TabIndex = 5;
            this.btnAyril.Text = "Ayrıl";
            this.btnAyril.UseVisualStyleBackColor = true;
            this.btnAyril.Visible = false;
            this.btnAyril.Click += new System.EventHandler(this.btnAyril_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(448, 10);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(123, 34);
            this.btnBaglan.TabIndex = 4;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(307, 16);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(111, 22);
            this.txtPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(49, 16);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(177, 22);
            this.txtIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.btnAyrilClient);
            this.tabPage3.Controls.Add(this.btnGonderClient);
            this.tabPage3.Controls.Add(this.txtGonderilenClient);
            this.tabPage3.Controls.Add(this.txtGelenClient);
            this.tabPage3.Controls.Add(this.btnBaglanClient);
            this.tabPage3.Controls.Add(this.txtClientPort);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtClientIP);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(737, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TCP/Client";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGonderClient
            // 
            this.btnGonderClient.Location = new System.Drawing.Point(591, 347);
            this.btnGonderClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonderClient.Name = "btnGonderClient";
            this.btnGonderClient.Size = new System.Drawing.Size(123, 60);
            this.btnGonderClient.TabIndex = 17;
            this.btnGonderClient.Text = "Gönder";
            this.btnGonderClient.UseVisualStyleBackColor = true;
            this.btnGonderClient.Click += new System.EventHandler(this.btnGonderClient_Click);
            // 
            // txtGonderilenClient
            // 
            this.txtGonderilenClient.Location = new System.Drawing.Point(23, 347);
            this.txtGonderilenClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderilenClient.Multiline = true;
            this.txtGonderilenClient.Name = "txtGonderilenClient";
            this.txtGonderilenClient.Size = new System.Drawing.Size(547, 59);
            this.txtGonderilenClient.TabIndex = 16;
            // 
            // txtGelenClient
            // 
            this.txtGelenClient.Location = new System.Drawing.Point(23, 62);
            this.txtGelenClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtGelenClient.Multiline = true;
            this.txtGelenClient.Name = "txtGelenClient";
            this.txtGelenClient.Size = new System.Drawing.Size(689, 277);
            this.txtGelenClient.TabIndex = 15;
            // 
            // btnBaglanClient
            // 
            this.btnBaglanClient.Location = new System.Drawing.Point(448, 10);
            this.btnBaglanClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglanClient.Name = "btnBaglanClient";
            this.btnBaglanClient.Size = new System.Drawing.Size(123, 34);
            this.btnBaglanClient.TabIndex = 13;
            this.btnBaglanClient.Text = "Bağlan";
            this.btnBaglanClient.UseVisualStyleBackColor = true;
            this.btnBaglanClient.Click += new System.EventHandler(this.btnBaglanClient_Click);
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(307, 16);
            this.txtClientPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(111, 22);
            this.txtClientPort.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "PORT";
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(49, 16);
            this.txtClientIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(177, 22);
            this.txtClientIP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // btnAyrilClient
            // 
            this.btnAyrilClient.Location = new System.Drawing.Point(589, 10);
            this.btnAyrilClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyrilClient.Name = "btnAyrilClient";
            this.btnAyrilClient.Size = new System.Drawing.Size(123, 34);
            this.btnAyrilClient.TabIndex = 18;
            this.btnAyrilClient.Text = "Ayrıl";
            this.btnAyrilClient.UseVisualStyleBackColor = true;
            this.btnAyrilClient.Visible = false;
            this.btnAyrilClient.Click += new System.EventHandler(this.btnAyrilClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 452);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAyril;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtGonderilenMesaj;
        private System.Windows.Forms.TextBox txtGelenMesaj;
        private System.Windows.Forms.Button btnGonderClient;
        private System.Windows.Forms.TextBox txtGonderilenClient;
        private System.Windows.Forms.TextBox txtGelenClient;
        private System.Windows.Forms.Button btnBaglanClient;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtGidenPort;
        private System.Windows.Forms.Button btnGonderPort;
        private System.Windows.Forms.Button btnSilPort;
        private System.Windows.Forms.TextBox txtGelenPort;
        private System.Windows.Forms.Button btnBaglantiKesPort;
        private System.Windows.Forms.Button btnBaglanPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGidenPort2;
        private System.Windows.Forms.Button btnGonderPort2;
        private System.Windows.Forms.Button btnSilPort2;
        private System.Windows.Forms.TextBox txtGelenPort2;
        private System.Windows.Forms.Button btnBaglantiKesPort2;
        private System.Windows.Forms.Button btnBaglanPort2;
        private System.Windows.Forms.ComboBox comboBoxPorts2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btnAyrilClient;
    }
}

