using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class HomeMonitor : Form
    {
        public HomeMonitor()
        {
            InitializeComponent();
        }
        private void clientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente frm = new ConsultaCliente();
            frm.Show();
        }

        private void HomeMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuarios frm = new CadastroUsuarios();
            frm.Show();
        }
    }
}
