using EMCatraca.Henry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIp
{
    public partial class frmCliente2 : Form
    {
        CatracaController cliente = new CatracaController();
        public frmCliente2()
        {
            InitializeComponent();
            cliente._catraca.Eventos.AoAlterarStatus += CatracaStatus_Change;
            cliente._catraca.Eventos.AoReceberDados += CatracaDados_Change;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //CatracaModel catraca = new CatracaModel();
            cliente._catraca.Codigo = 1;
            cliente._catraca.Descricao = "Catraca 1";
            cliente._catraca.Ip = txtServidor.Text;
            cliente._catraca.Porta = txtPorta.Text;
            
            cliente.IniciaMonitorCatraca();
        }

        private void BtnResponderString_Click(object sender, EventArgs e)
        {
            cliente.EnviaMensagemEmBytes(txtEnviaString.Text);
        }
        private void BtnFinaliza_Click(object sender, EventArgs e)
        {
            cliente.executarClient = false;
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
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

        private void BtnLimparLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }




        private void CatracaStatus_Change(object sender, EventArgs e)
        {
            AlteraStatus(cliente._catraca);
        }
        delegate void AlteraStatusCallback(CatracaModel catraca);
        void AlteraStatus(CatracaModel catraca)
        {
            if (InvokeRequired)
            {
                AlteraStatusCallback callback = AlteraStatus;
                try { Invoke(callback, catraca); } catch { }
            }
            else
            {
                this.Show();
                lblStatus.Text = Enum.GetName(typeof(EnumeradorEstadoDaCatraca), catraca.EstadoCatraca);
                Console.WriteLine(Enum.GetName(typeof(EnumeradorEstadoDaCatraca), catraca.EstadoCatraca));
            }
        }

        private void CatracaDados_Change(object sender, EventArgs e)
        {
            AlteraDados(cliente._catraca);
        }
        delegate void AlteraDadosCallback(CatracaModel catraca);
        void AlteraDados(CatracaModel catraca)
        {
            if (InvokeRequired)
            {
                AlteraDadosCallback callback = AlteraDados;
                try { Invoke(callback, catraca); } catch { }
            }
            else
            {
                this.Show();
                txtLog.Text = catraca.Dados;
                Console.WriteLine(catraca.Dados);
            }
        }

        private void TxtEnviaString_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblEnviaString_Click(object sender, EventArgs e)
        {

        }

        private void LblLog_Click(object sender, EventArgs e)
        {

        }
    }
}
