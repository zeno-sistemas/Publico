using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace TcpIp
{
    public partial class frmServidor : Form
    {
        #region private members 	
        private TcpListener tcpListener;
        private Thread tcpListenerThread;
        private TcpClient connectedTcpClient;
        #endregion
        public bool executar = true;
        CatracaHenry8x catracaHenry8X = new CatracaHenry8x();

        public frmServidor()
        {
            InitializeComponent();
        }



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {

        }


        void Start()
        {
            tcpListenerThread = new Thread(new ThreadStart(ListenForIncommingRequests));
            tcpListenerThread.IsBackground = true;
            tcpListenerThread.Start();
        }
        
        private void ListenForIncommingRequests()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(txtServidor.Text), int.Parse(txtPorta.Text));
                tcpListener.Start();
                EmitirStatus("Servidor está escutando");
                Byte[] bytes = new Byte[1024];
                while (executar)
                {
                    using (connectedTcpClient = tcpListener.AcceptTcpClient())
                    {
                        using (NetworkStream stream = connectedTcpClient.GetStream())
                        {
                            int length;
                            while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                            {
                                var incommingData = new byte[length];
                                Array.Copy(bytes, 0, incommingData, 0, length);
                                string clientMessage = Encoding.ASCII.GetString(incommingData);
                                ReceberMensagem(clientMessage);
                                EmitirStatus("Recebendo dados");
                            }
                        }
                    }
                }
            }
            catch (SocketException socketException)
            {
                EmitirStatus("Falha do Socket: " + socketException.ToString());
            }
        }

        delegate void EmitirStatusCallback(string msg);
        void EmitirStatus(string msg)
        {
            if (InvokeRequired)
            {
                EmitirStatusCallback callback = EmitirStatus;
                Invoke(callback, msg);
            }
            else
            {
                this.Show();
                lblStatus.Text = msg;
            }
        }

        delegate void ReceberMensagemCallback(string msg);
        void ReceberMensagem(string msg)
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = ReceberMensagem;
                Invoke(callback, msg);
            }
            else
            {
                this.Show();
                byte[] clientMessageAsByteArray = catracaHenry8X.MontaProtocolo(msg);
                txtRecebeBytes.Text = BitConverter.ToString(clientMessageAsByteArray).Replace("-", " ");
                if (clientMessageAsByteArray.Length > 10) txtRecebeString.Text = catracaHenry8X.RecuperaTextoMensagem("Recebeu", clientMessageAsByteArray);
            }
        }

        private void SendMessageBytes(byte[] mensagem)
        {
            if (connectedTcpClient == null)
            {
                return;
            }

            try
            {
                NetworkStream stream = connectedTcpClient.GetStream();
                stream.Write(mensagem, 0, mensagem.Length);
                lblStatus.Text = "Servidor enviou a mensagem ao Cliente";
            }
            catch (SocketException socketException)
            {
                lblStatus.Text = "Falha do Socket: " + socketException.ToString();
            }
        }


        private void SendMessageString(string serverMessage)
        {
            if (connectedTcpClient == null)
            {
                return;
            }

            try
            {
                NetworkStream stream = connectedTcpClient.GetStream();
                if (stream.CanWrite)
                {
                    byte[] serverMessageAsByteArray = Encoding.ASCII.GetBytes(serverMessage);
                    stream.Write(serverMessageAsByteArray, 0, serverMessageAsByteArray.Length);
                    lblStatus.Text = "Servidor enviou a mensagem ao Cliente";
                }
            }
            catch (SocketException socketException)
            {
                lblStatus.Text = "Falha do Socket: " + socketException.ToString();
            }
        }

        private void btnResponderBytes_Click(object sender, EventArgs e)
        {
            SendMessageBytes(StringToByteArray(txtEnviaBytes.Text.Replace(" ", "")));
        }

        private void btnResponderString_Click(object sender, EventArgs e)
        {
            SendMessageString(txtEnviaBytes.Text);

        }


        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void frmServidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            executar = false;
            tcpListenerThread.Abort();
        }
    }
}
