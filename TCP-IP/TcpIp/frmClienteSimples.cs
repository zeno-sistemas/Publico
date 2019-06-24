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

namespace TcpIp
{
    public partial class frmClienteSimples : Form
    {
        public frmClienteSimples()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            TcpClient tcpCliente = new TcpClient();
            tcpCliente.Connect(txtServidor.Text, int.Parse(txtPorta.Text));
            NetworkStream stream = tcpCliente.GetStream();
            byte[] byteMensagem = Encoding.ASCII.GetBytes(txtEnviaString.Text);
            stream.Write(byteMensagem, 0, byteMensagem.Length);

            //read

            Application.DoEvents();
            string teste = LeiaDadosCatraca(tcpCliente);
            txtLog.Text = teste.Substring(3) + "\n\r" + txtLog.Text;


            tcpCliente.Close();
        }

        private string LeiaDadosCatraca(TcpClient ConexaoTcp)
        {
            const int TamanhoBuffer = 1024;
            var bytes = new byte[TamanhoBuffer];
            int length = ConexaoTcp.GetStream().Read(bytes, 0, TamanhoBuffer);
            return Encoding.ASCII.GetString(bytes, 0, length);
        }
    }
}
