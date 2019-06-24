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
    public partial class frmCatraca2 : Form
    {
        CatracaServerEmulador server = new CatracaServerEmulador();

        public frmCatraca2()
        {
            InitializeComponent();
            server._catraca.Eventos.AoAlterarStatus += CatracaStatus_Change;
            server._catraca.Eventos.AoReceberDados += CatracaDados_Change;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            server.IniciarEmuladorCatraca(txtServidor.Text, txtPorta.Text);
        }

        private void BtnSolicita_Click(object sender, EventArgs e)
        {
            server.EnviaMensagemEmBytes(txtComando.Text);
        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {
            string comando = "15+REON+000+0]{0}]{1} {2}]1]0]";
            comando = string.Format(comando, txtMatricula.Text.Trim(), DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            txtComando.Text = comando;
        }

        private void BtnFinaliza_Click(object sender, EventArgs e)
        {
            server.executarServer = false;
        }


        private void CatracaStatus_Change(object sender, EventArgs e)
        {
            AlteraStatus(server._catraca);
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
            AlteraDados(server._catraca);
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

    }
}
