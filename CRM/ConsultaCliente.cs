using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TransferenciaDados;

namespace CRM
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            Lojas dados = new Lojas();

            dados.Codigo = txtCodigo.Text;
            dados.RazaoSocial = txtRazao.Text;
            dados.CNPJ = txtCNPJ.Text;
            
            if (txtCNPJ.Text.Equals("") && txtCodigo.Text.Equals("") && txtRazao.Text.Equals(""))
            {

                dgConsultarPacientes.DataSource = dados.PesquisarLojaSemFiltro(dt);

                if (dgConsultarPacientes.RowCount == 0)
                {
                    MessageBox.Show("Nenhum registro foi encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (txtCodigo.Text != "")
            {
                dgConsultarPacientes.DataSource = dados.PesquisarcomfiltroCodigo(dt, dados);
                
                if (dgConsultarPacientes.RowCount == 0)
                {
                    MessageBox.Show("Nenhum registro foi encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                dgConsultarPacientes.DataSource = dados.PesquisarcomfiltroCNPJouRazao(dt, dados);
                if (dgConsultarPacientes.RowCount == 0)
                {
                    MessageBox.Show("Nenhum registro foi encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int campoID = 0;
            CadastrarLoja cadLoja = new CadastrarLoja(campoID);
            cadLoja.Show();
        }

        private void dgConsultarPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            int campoID = Convert.ToInt32(dgConsultarPacientes.CurrentRow.Cells[0].Value);

            CadastrarLoja cadform = new CadastrarLoja(campoID);

            //cadform.ID = campoID;
            cadform.Show();



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgConsultarPacientes.DataSource = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            Lojas dados = new Lojas();
            DataTable dt = new DataTable();


            int ID = Convert.ToInt32(dgConsultarPacientes.CurrentRow.Cells[0].Value);
            dados.ID = ID;
            DialogResult confirma = MessageBox.Show("Tem certeza que deseja apagar o ID = " + dados.ID + "?","Excluir" ,MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirma.ToString().ToUpper()=="YES")
            {
                try
                {
                    dados.ApagarLoja(dados);
                    MessageBox.Show("Apagado com sucesso!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
                dgConsultarPacientes.DataSource = dados.PesquisarLojaSemFiltro(dt);
            }
            
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
