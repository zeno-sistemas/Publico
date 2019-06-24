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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente form = new frmCliente();
            form.Show();
        }

        private void btnCatraca_Click(object sender, EventArgs e)
        {
            frmCatraca form = new frmCatraca();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServerMulti form = new frmServerMulti();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmClientMulti form = new frmClientMulti();
            form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmCatraca2 form = new frmCatraca2();
            form.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            frmCliente2 form = new frmCliente2();
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmClienteSimples form = new frmClienteSimples();
            form.Show();
        }
    }
}
