using System;
using System.Windows.Forms;

namespace TcpIp
{
    public partial class frmServerMulti : Form
    {

        private ServidorTcpIp tcpServidor;
        private ClienteTcpIp cliente = new ClienteTcpIp();

        public frmServerMulti()
        {
            InitializeComponent();
            cliente.Cliente_Change += Client_Change;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcpServidor = new ServidorTcpIp();
            tcpServidor.IniciarServidorTcpIp("192.168.1.54", 5000);
            button1.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //tcpServidor.EnviaMensagemParaTodos(textBox1.Text);
            cliente.EnviarMensagem(txtEnviar.Text);
            txtEnviar.Text = "";
            txtEnviar.Lines = null;
            txtEnviar.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.Iniciar("192.168.1.54", 5000);
            cliente.Cliente_Change += Client_Change;
        }

        private void frmServerMulti_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliente.FecharConeccao();
            tcpServidor.EnviarEncerramento(false);
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

        private void button2_Click(object sender, EventArgs e)
        {
            cliente.FecharConeccao();
            tcpServidor.EnviarEncerramento(false);
        }
    }

    
}
