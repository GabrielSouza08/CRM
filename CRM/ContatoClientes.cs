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
    public partial class ContatoClientes : Form
    {
        public int IDCliente;
        public int IDContato;

        public DataTable dt = new DataTable();

        public ContatoClientes(int IDLoja)
        {
            InitializeComponent();
            IDCliente = IDLoja;
        }

        private void ContatoCliente_Load(object sender, EventArgs e)
        {
            //instanciando a classe para chamar o metodo
            
            //chamando os construtores
            Contato contato = new Contato();

            //Instancio para jogar o retorno do metodo
            

            contato.IDLoja = IDCliente;

            //chamando o metodo para preencher o grid
            dgContatos.DataSource = contato.PreencherGridContato(dt, contato);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            Contato contato = new Contato();
            if (IDContato == 0)
            {
                
                try
                {
                    //pegando o campo loja
                    contato.IDLoja = IDCliente;

                    contato.Telefone = txtDDD.Text + txtTelefone.Text;
                    contato.Nome = txtNomeContato.Text;
                    contato.Email = txtEmail.Text;
                    contato.Perfil = cmbPerfil.Text;

                    //cadastrando o contato
                    contato.CadastrarContato(contato);
                    MessageBox.Show("Inserido com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDDD.Text = "";
                    txtTelefone.Text = "";
                    txtNomeContato.Text = "";
                    txtEmail.Text = "";

                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    dgContatos.DataSource = contato.PreencherGridContato(dt, contato);
                }
            }
            else
            {
                try
                {
                    contato.ID = IDContato;
                    contato.Telefone = txtDDD.Text + txtTelefone.Text;
                    contato.Nome = txtNomeContato.Text;
                    contato.Email = txtEmail.Text;
                    contato.Perfil = cmbPerfil.Text;
                    contato.IDLoja = IDCliente;
                    contato.AlterarContato(contato);
                    MessageBox.Show("Alterado com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Rows.Clear();
                    IDContato = 0;
                    txtDDD.Text = "";
                    txtTelefone.Text = "";
                    txtNomeContato.Text = "";
                    txtEmail.Text = "";
                }
         

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    dgContatos.DataSource = contato.PreencherGridContato(dt, contato);
                }
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
            Contato contato = new Contato();
            try
            {
                contato.IDLoja = IDCliente;
                contato.ID = Convert.ToInt32(dgContatos.CurrentRow.Cells[0].Value);
                DialogResult confirma = MessageBox.Show("Tem certeza que deseja apagar Contato?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirma.ToString().ToUpper() == "YES")
                {
                    contato.ExcluirContato(contato);
                    MessageBox.Show("Apagado com sucesso!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Rows.Clear();
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                dgContatos.DataSource = contato.PreencherGridContato(dt, contato);
            }

        }

        private void dgContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
            IDContato = Convert.ToInt32(dgContatos.CurrentRow.Cells[0].Value);
            txtNomeContato.Text = dgContatos.CurrentRow.Cells[1].Value.ToString();
            
            string telefone = dgContatos.CurrentRow.Cells[2].Value.ToString();
            
            txtDDD.Text = telefone.Substring(0,2);
            txtTelefone.Text = telefone.Substring(2, telefone.Length - 2);
            txtEmail.Text = dgContatos.CurrentRow.Cells[3].Value.ToString();
            cmbPerfil.Text = dgContatos.CurrentRow.Cells[4].Value.ToString();


            
            

        }
    }
}
