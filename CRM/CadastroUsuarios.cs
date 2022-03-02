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
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }
        public int ID;
        DataTable dt = new DataTable();
        
        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            dgUsuarios.DataSource = usuario.PesquisarUsuario(dt);
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgUsuarios.CurrentRow.Cells[0].Value);
            Usuario usuario = new Usuario();
            usuario.ID = ID;
            usuario.PreencherUsuario(usuario);

            txtNome.Text = usuario.Nome;
            txtAlerarSenha.Text = usuario.Senha;
            cmbPerfil.Text = usuario.Perfil;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            try
            {
                usuario.Nome = txtNome.Text;
                usuario.Senha = txtAlerarSenha.Text;
                usuario.Perfil = cmbPerfil.Text;

                usuario.CadastrarUsuario(usuario);
                MessageBox.Show("Usuario inserido com sucesso","Usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);


            }

            finally
            {
                dt.Clear();
                dgUsuarios.DataSource = usuario.PesquisarUsuario(dt);

                txtNome.Text = "";
                txtAlerarSenha.Text = "";
                cmbPerfil.Text = "";
            }

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario.ID = ID;
                usuario.Senha = txtAlerarSenha.Text;

                usuario.AlterarSenha(usuario);
                MessageBox.Show("Senha alterada com sucesso","Alterar Senha",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtAlerarSenha.Enabled = false;
                btnAlterarSenha.Enabled = false;
                optNao.Checked = true;
            }
        }

        private void optNao_Click(object sender, EventArgs e)
        {
            optNao.Checked = true;
            optSim.Checked = false;
            txtAlerarSenha.Enabled = false;
            btnAlterarSenha.Enabled = false;
        }

        private void optSim_Click(object sender, EventArgs e)
        {

            optNao.Checked = false;
            optSim.Checked = true;
            txtAlerarSenha.Enabled = true;
            txtAlerarSenha.Text = "";
            btnAlterarSenha.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario.ID = ID;
                usuario.ExcluirUsuario(usuario);
                MessageBox.Show("Excluido com sucesso","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dt.Clear();
                dgUsuarios.DataSource = usuario.PesquisarUsuario(dt);
            }
           
        }
    }
}
