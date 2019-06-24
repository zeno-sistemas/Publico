using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIp
{
    public partial class frmCatraca : Form
    {
        CatracaHenry8x catracaHenry8x = new CatracaHenry8x();
        public frmCatraca()
        {
            InitializeComponent();

            catracaHenry8x.eventos.CatracaHenry8xStatus_RecebeStatus += CatracaHenry8xStatus_Change;
            catracaHenry8x.eventos.CatracaHenry8x_RecebeDados += CatracaHenry8xDadosRecebidos;
        }



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            catracaHenry8x.configuracao.Log = false;
            catracaHenry8x.IniciarEmuladorCatraca(txtServidor.Text, txtPorta.Text);
        }

        private void btnSolicita_Click(object sender, EventArgs e)
        {
            catracaHenry8x.EnviaMensagemEmBytes(txtComando.Text);
            txtResultado.Text = "\r\nEnviou\r\n" + txtComando.Text + "\r\n" + txtResultado.Text;
        }

        private void CatracaHenry8xStatus_Change(object sender, EventArgs e)
        {
            EmitirStatus(catracaHenry8x.status);
        }

        private void CatracaHenry8xDadosRecebidos (object sender, EventArgs e)
        {
            EmitirDadosRecebidos(catracaHenry8x.dadosRecebidos);
        }

        delegate void EmitirStatusCallback(CatracaStatus status);
        void EmitirStatus(CatracaStatus status)
        {
            if (InvokeRequired)
            {
                EmitirStatusCallback callback = EmitirStatus;
                try { Invoke(callback, status); } catch { }
            }
            else
            {
                this.Show();
                lblStatus.Text = status.Status;
                Console.WriteLine(status.Mensagem);
            }
        }

        delegate void DadosRecebidosCallback(CatracaDadosRecebidos dadosRecebidos);
        void EmitirDadosRecebidos(CatracaDadosRecebidos dados)
        {
            if (InvokeRequired)
            {
                DadosRecebidosCallback callback = EmitirDadosRecebidos;
                Invoke(callback, dados);
            }
            else
            {
                this.Show();
                lblStatus.Text = "Recebeu";
                txtResultado.Text = "\r\nRecebeu\r\n" + dados.DadosString + "\r\n" + txtResultado.Text;
                string[][] str = catracaHenry8x.FiltraMensagem(dados.DadosString);
                if (str.Length >= 4)
                {
                    if (str[0].Length == 4 && str[0][1] == "REON")
                    {
                        if (str[0][3].Equals("5") || str[0][3].Equals("6") || str[0][3].Equals("1"))
                        {
                            string comando = "15+REON+000+80]{0}]{1} {2}]1]0]";
                            comando = string.Format(comando, txtMatricula.Text.Trim(), DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
                            catracaHenry8x.EnviaMensagemEmBytes(comando);
                            txtResultado.Text = "\r\nEnviou\r\n" + comando + "\r\n" + txtResultado.Text;
                        }
                        if (str[0][3].Equals("30"))
                        {
                            txtMatricula.Focus();

                            string comando = "15+REON+000+80]{0}]{1} {2}]1]0]";
                            comando = string.Format(comando, txtMatricula.Text.Trim(), DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
                            catracaHenry8x.EnviaMensagemEmBytes(comando);
                            txtResultado.Text = "\r\nEnviou\r\n" + comando + "\r\n" + txtResultado.Text;
                        }
                    }
                }
            }
        }


        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            string comando = "15+REON+000+0]{0}]{1} {2}]1]0]";
            comando = string.Format(comando, txtMatricula.Text.Trim(), DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            txtComando.Text = comando;
        }

        private void frmCatraca_FormClosing(object sender, FormClosingEventArgs e)
        {
            catracaHenry8x.executarClient = false;
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Desconectou";
            catracaHenry8x.executarServer = false;
        }

        private void btnGira_Click(object sender, EventArgs e)
        {
            //Girou a catraca
            string comando = "01+REON+00+81]{0}]{1} {2}]1]0]1]";
            comando = string.Format(comando, txtMatricula.Text.Trim(), DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            txtComando.Text = comando;

            catracaHenry8x.EnviaMensagemEmBytes(txtComando.Text);
            txtResultado.Text = "\r\nEnviou\r\n" + comando + "\r\n" + txtResultado.Text;

            txtMatricula.Focus();
        }

        private void btnNaoGira_Click(object sender, EventArgs e)
        {
            //Não girou a catraca
            string comando = "01+REON+00+82]{0}]{1} {2}]1]0]1]";
            comando = string.Format(comando, txtMatricula.Text.Trim(), DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            txtComando.Text = comando;

            catracaHenry8x.EnviaMensagemEmBytes(txtComando.Text);
            txtResultado.Text = "\r\nEnviou\r\n" + comando + "\r\n" + txtResultado.Text;

            txtMatricula.Focus();
        }

        private void btnLimparLog_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }

    

}
