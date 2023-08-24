using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace TCPServer_SerialPortApp
{
    public partial class Form1 : Form
    {
        public bool donguKontrolServer = true;
        public bool donguKontrolClient = true;
        #region Server nesneleri
        public Thread _thread;
        public IPAddress _IPAddress;
        public TcpListener _dinle;
        public Socket _socket;
        public NetworkStream _ag;
        public StreamReader _streamReader;
        public StreamWriter _streamWriter;
        public delegate void ricdegis(string text);

        #endregion
        #region Client Nesneleri
        Thread t;
        TcpClient baglantikur;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string ports in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(ports);
                comboBoxPorts2.Items.Add(ports);
            }
            #region SerialPortEnabled
            btnGonderPort.Enabled = false;
            btnGonderPort2.Enabled = false;
            btnBaglantiKesPort.Enabled = false;
            btnBaglantiKesPort2.Enabled = false;
            #endregion
            #region ClientButtonKontrol
            btnBaglanClient.Enabled = true;
            btnAyrilClient.Enabled = false;
            #endregion
            try
            {
                comboBoxPorts.SelectedIndex = 0;
                comboBoxPorts2.SelectedIndex = 1;
            }
            catch
            {
                return;
            }

        }
        public void _OkumayaBasla()
        {
            _socket = _dinle.AcceptSocket();
            _ag = new NetworkStream(_socket);
            _streamReader = new StreamReader(_ag);


            while (donguKontrolServer)
            {
                try
                {
                    string yazi = _streamReader.ReadLine();
                    if (yazi == null)
                    {
                        donguKontrolServer = false;
                    }
                    else
                    {
                        _ekranabas(yazi);
                    }
                }
                catch
                {
                    donguKontrolServer = false;
                }
            }
        }
        public void _ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(_ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                s = " Client: " + s;
                txtGelenMesaj.AppendText(s);
                //txtGelenMesaj.Text += s;
            }
        }
        private void _dinlemeyebasla()
        {
            try
            {
                _IPAddress = IPAddress.Parse(txtIP.Text);
                _dinle = new TcpListener(_IPAddress, Convert.ToInt32(txtPort.Text));
                _dinle.Start();
                _thread = new Thread(new ThreadStart(_OkumayaBasla));
                _thread.Start();
                txtGelenMesaj.AppendText(" Dinleme baslatildi... ");
            }
            catch (Exception)
            {
                MessageBox.Show("Dinleme baslatilamadi");
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            _dinlemeyebasla();
        }

        private void btnAyril_Click(object sender, EventArgs e)
        {
            //ilk client kapatılmalı dimi chatgpt o yüzden mi hata alıyoruma


            donguKontrolServer = false;
            if (_ag != null)
            {
                _ag.Close();
            }
            if (_streamReader != null)
            {
                _streamReader.Close();
            }
            if (_streamWriter != null)
            {
                _streamWriter.Close();
            }
            if (_socket != null && _socket.Connected)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Poll(1000, SelectMode.SelectRead);
                _socket.Close();
            }
            _socket = null;
            _dinle.Stop();
            _thread.Abort();
            /*   
           _thread = new Thread(new ThreadStart(_OkumayaBasla));
           _thread.Start();*/
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonderilenMesaj.Text == "")
            {
                return;
            }
            else
            {
                _streamWriter = new StreamWriter(_ag);
                _streamWriter.WriteLine(txtGonderilenMesaj.Text);
                _streamWriter.Flush();
                //
                txtGonderilenMesaj.Text = "";
            }
        }
        public void okumayabasla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);

            while (donguKontrolClient)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    if (yazi == null)
                    {
                        donguKontrolClient = false;
                    }
                    else
                    {
                        ekranabas(yazi);
                    }
                }
                catch
                {
                    donguKontrolClient = false;
                }
            }
        }

        // Clientde Method_2 (Okunan Veri richTextBox icine yaziliyor)
        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                s = " Server: " + s;
                txtGelenClient.AppendText(s + "\n");
            }
        }

        // Clientde Method_3 (Istenilen IP'ye istenen Port üzerinden baglaniliyor)
        public void baglanti_kur()
        {
            try
            {
                //Ben Lochalhos üzerinde deneme yapacagim icin 127.0.0.1 verdim
                baglantikur = new TcpClient(txtClientIP.Text, Convert.ToInt16(txtClientPort.Text));
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
                txtGelenClient.AppendText(DateTime.Now.ToString() + " Baglanti kuruldu... \n");
            }
            catch (Exception)
            {

                MessageBox.Show("Server ile baglanti kurulurken hata olustu !");
            }
        }

        private void btnBaglanClient_Click(object sender, EventArgs e)
        {
            temizlikYap();
            baglanti_kurClient();
            //btnAyrilClient.Enabled = true;
            //btnBaglanClient.Enabled = false;
        }


        private void btnGonderClient_Click(object sender, EventArgs e)
        {
            if (txtGonderilenClient.Text == "")
            {
                //Burda bos alan göndermeyi önlüyoruz...
                return;
            }
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(txtGonderilenClient.Text);
                yaz.Flush();
                //txtGelenClient.AppendText(txtGonderilenClient.Text + "\n");
                txtGonderilenClient.Text = "";
            }
        }


        private void temizlikYap()
        {
            if (baglantikur != null)
            {
                if (baglantikur.Connected)
                {
                    try
                    {
                        baglantikur.GetStream().Close();
                        baglantikur.Close();
                        t.Abort();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
        public void baglanti_kurClient()
        {
            try
            {
                // Eğer baglantikur zaten bir bağlantı içeriyorsa, önceki bağlantıyı kapat.
                if (baglantikur != null && baglantikur.Connected)
                {
                    baglantikur.GetStream().Close();
                    baglantikur.Close();
                }

                // Yeni bir TcpClient nesnesi oluştur ve belirtilen IP ve port üzerinden bağlan.
                baglantikur = new TcpClient(txtClientIP.Text, Convert.ToInt32(txtClientPort.Text));

                // Okuma işlemi için bir StreamReader oluştur.
                ag = baglantikur.GetStream();
                oku = new StreamReader(ag);

                // Okuma işlemini başlatan bir thread oluştur ve başlat.
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();

                txtGelenClient.AppendText(DateTime.Now.ToString() + " Bağlantı kuruldu... \n");
                btnAyrilClient.Enabled = true;
                btnBaglanClient.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sunucu ile bağlantı kurulurken hata oluştu: " + ex.Message);
            }
        }


        private void btnBaglanPort_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPorts.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port bağlantısı yapılamadı.\nHata: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort1.IsOpen)
            {
                btnBaglanPort.Enabled = false;
                btnBaglantiKesPort.Enabled = true;
                btnGonderPort.Enabled = true;
            }
        }

        private void btnBaglantiKesPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnBaglantiKesPort.Enabled = false;
                btnBaglanPort.Enabled = true;
                btnGonderPort.Enabled = false;
            }
        }

        private void btnGonderPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtGidenPort.Text);
                txtGidenPort.Clear();
            }
        }
        public delegate void veriGoster(String s);
        public void textBoxYaz(String s)
        {
            txtGelenPort.Text += s;
        }
        public void textBoxYaz2(String s)
        {
            txtGelenPort2.Text += s;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenVeri = serialPort1.ReadExisting();
            txtGelenPort.Invoke(new veriGoster(textBoxYaz), gelenVeri);
        }

        private void btnBaglanPort2_Click(object sender, EventArgs e)
        {
            serialPort2.PortName = comboBoxPorts2.Text;
            serialPort2.BaudRate = 9600;
            serialPort2.Parity = Parity.Even;
            serialPort2.StopBits = StopBits.One;
            serialPort2.DataBits = 8;

            try
            {
                serialPort2.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı yapılamadı...\nHata: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort2.IsOpen)
            {
                btnBaglanPort2.Enabled = false;
                btnBaglantiKesPort2.Enabled = true;
                btnGonderPort2.Enabled = true;
            }
        }

        private void btnBaglantiKesPort2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                btnGonderPort2.Enabled = false;
                btnBaglantiKesPort2.Enabled = false;
                btnBaglanPort2.Enabled = true;
            }
        }

        private void btnGonderPort2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(txtGidenPort2.Text);
                txtGidenPort2.Clear();
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenVeri = serialPort2.ReadExisting();
            txtGelenPort2.Invoke(new veriGoster(textBoxYaz2), gelenVeri);
        }

        private void btnSilPort_Click(object sender, EventArgs e)
        {
            txtGelenPort.Text = "";
        }

        private void btnSilPort2_Click(object sender, EventArgs e)
        {
            txtGelenPort2.Text = "";
        }

        private void btnAyrilClient_Click(object sender, EventArgs e)
        {
            ag = baglantikur.GetStream();
            ag.Close();
            baglantikur.Close();
            btnBaglanClient.Enabled = true;
            btnAyrilClient.Enabled = false;
        }
    }
}
