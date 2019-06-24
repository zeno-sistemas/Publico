using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace TcpIp
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        CatracaHenry8x catracaHenry8x = new CatracaHenry8x();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciarMonitoramento(txtServidor.Text, txtPorta.Text);

        }

        private void iniciarMonitoramento(string ip, string porta)
        {
            catracaHenry8x.configuracao.Codigo = 1;
            catracaHenry8x.configuracao.Descricao = "Catraca 1";
            catracaHenry8x.configuracao.Ip = ip;
            catracaHenry8x.configuracao.Porta = porta;
            catracaHenry8x.configuracao.Log = true;


            Thread threadMonitoramento = new Thread(() => catracaHenry8x.IniciaMonitorCatraca(catracaHenry8x.configuracao));
            threadMonitoramento.IsBackground = true;
            threadMonitoramento.Start();

            //catracaHenry8x.IniciaMonitorCatraca(catracaHenry8x.configuracao);
            catracaHenry8x.eventos.CatracaHenry8xStatus_RecebeStatus += CatracaHenry8xStatus_Change;
            catracaHenry8x.eventos.CatracaHenry8x_RecebeDados += CatracaHenry8xDadosRecebidos;
        }

        private void CatracaHenry8xStatus_Change(object sender, EventArgs e)
        {
            EmitirStatus(catracaHenry8x.status);
        }

        private void CatracaHenry8xDadosRecebidos(object sender, EventArgs e)
        {
            ReceberMensagem(catracaHenry8x.dadosRecebidos);
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
                try { this.Show(); } catch { }
                lblStatus.Text = status.Status;
                //if(status.Status.Equals("Desconectado")) iniciarMonitoramento(txtServidor.Text, txtPorta.Text);
            }
        }

        delegate void ReceberMensagemCallback(CatracaDadosRecebidos dadosRecebidos);
        void ReceberMensagem(CatracaDadosRecebidos dadosRecebidos)
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = ReceberMensagem;
                Invoke(callback, dadosRecebidos);
            }
            else
            {
                this.Show();

                txtLog.Text = "Recebeu:\r\n" + dadosRecebidos.DadosString + "\r\n\r\n" + BitConverter.ToString(dadosRecebidos.DadosBytes).Replace("-", " ") + "\r\n\r\n" + txtLog.Text;
            }
        }

        private void btnResponderString_Click(object sender, EventArgs e)
        {
            txtLog.Text = "Enviou:\r\n" + txtEnviaString.Text + "\r\n\r\n" + BitConverter.ToString(catracaHenry8x.MontaProtocolo(txtEnviaString.Text)).Replace("-", " ") + "\r\n\r\n" + txtLog.Text;
            catracaHenry8x.EnviaMensagemEmBytes(txtEnviaString.Text);
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void btnLimpaResposta_Click(object sender, EventArgs e)
        {
            txtEnviaString.Text = "";
            txtEnviaString.Focus();
        }

        private void btnPreparaEnvio_Click(object sender, EventArgs e)
        {
            string tipoEnvio = "";
            string textoEnvio = "01+REON+00+{0}]{1}]{2}{3}{4}]";
            if (radEventos1.Checked) tipoEnvio = "5";
            if (radEventos2.Checked) tipoEnvio = "6";
            if (radEventos3.Checked) tipoEnvio = "1";
            if (radEventos4.Checked) tipoEnvio = "30";

            string mensagem2 = txtMensagem2.Text;
            if (!string.IsNullOrEmpty(mensagem2)) mensagem2 = "}" + mensagem2;

            string rele = "";
            if (chkRele1.Checked) rele += "1";
            if (chkRele2.Checked) rele += "2";
            if (chkRele3.Checked) rele += "3";
            if (!string.IsNullOrEmpty(rele)) rele = "]" + rele;

            txtEnviaString.Text = string.Format(textoEnvio,
                                                tipoEnvio,
                                                numTempo.Value, 
                                                txtMensagem1.Text, 
                                                mensagem2,
                                                rele);
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            catracaHenry8x.executarClient = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ping = new Ping();
            //var reply = ping.Send("192.168.1.54", 60 * 1000); // 1 minute time out (in ms)
            //var reply = ping.Send(new IPAddress(new byte[] { 192, 168, 1, 54 }), 50);

            //string ip = "104.27.169.204";
            //string ip = "192.168.1.54";
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Estatística de ping para: {ip}");
            //for (int i = 0; i < 100; i++)
            bool monitorarServidor = true;




            while(monitorarServidor)
            {
                StringBuilder sb = new StringBuilder();
                try
                {
                    string ip = "192.168.1.204";
                    var reply = ping.Send(ip, 1000);

                    if (reply.Status == IPStatus.Success)
                    {
                        sb.Append($"Conectado tempo={reply.RoundtripTime}");
                    }
                    else
                    {
                        sb.Append($"Falha={reply.Status}");
                    }

                }
                catch (Exception ex)
                {
                    sb.Append($"Erro={ex.Message}");
                }
                Console.WriteLine(sb.ToString());
                Application.DoEvents();
                Thread.Sleep(300);
            }

        }


        private void Button2_Click(object sender, EventArgs e)
        {

            var comandos = TcpipRecuperaComandos("{cmd|1|xxx}{cmd|2|yyy}");
            foreach (var comando in comandos)
            {
                System.Console.WriteLine(comando);
            }

            comandos = TcpipRecuperaComandos("");
            foreach (var comando in comandos)
            {
                System.Console.WriteLine(comando);
            }
            comandos = TcpipRecuperaComandos("{cmd|1|xxx}{cmd|2|yyy}{cmd|3|zzz}{cmd|4|aaa}");
            foreach (var comando in comandos)
            {
                System.Console.WriteLine(comando);
            }
        }

        private string[] TcpipRecuperaComandos(string entrada)
        {
            char[] delimitadores = { '{', '}' };

            string[] comandos = entrada.Split(delimitadores);
            return comandos.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        //PublicadorDeLogNoVisualizadorDeEventos.PubliqueErro($"Variável de ambiente {ChaveIntegracao} configurada incorretamente");
    }



}