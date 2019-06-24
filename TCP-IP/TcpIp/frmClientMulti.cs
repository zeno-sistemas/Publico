using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace TcpIp
{
    public partial class frmClientMulti : Form
    {
        private ClienteTcpIp cliente = new ClienteTcpIp();

        public frmClientMulti()
        {
            InitializeComponent();
            cliente.Cliente_Change += Client_Change;
            cliente.Iniciar("192.168.1.54", 5000);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cliente.EnviarMensagem(txtEnviar.Text);
            txtEnviar.Text = "";
            txtEnviar.Lines = null;
        }

        private void frmClientMulti_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliente.FecharConeccao();
        }

        private void Client_Change(object sender, EventArgs e)
        {
            EmitirStatus(cliente.resultado);
        }


        delegate void EmitirStatusCallback(string resultado);
        void EmitirStatus(string resultado)
        {
            if (InvokeRequired)
            {
                EmitirStatusCallback callback = EmitirStatus;
                Invoke(callback, resultado);
            }
            else
            {
                try
                {
                    this.Show();
                    txtMensagem.Text = resultado;
                }
                catch (Exception)
                {
                }
            }
        }

    }

    

}
