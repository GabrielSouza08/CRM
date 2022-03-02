using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.IO;
using ConexaoBanco;

namespace CRM
{
    public partial class ConfiguracaoBanco : Form
    {
        string enderecoServer, nomeBanco, senhaBanco;
        public ConfiguracaoBanco(string _enderecoServer, string _nomeBanco, string _senhaBanco)
        {
            InitializeComponent();
            enderecoServer = _enderecoServer;
            nomeBanco = _nomeBanco;
            senhaBanco = _senhaBanco;
        }

        private static string codificarSenha(string senha)
        {
            string data = senha;
            string encodedData = String.Empty;
            try
            {
                byte[] data_byte = Encoding.UTF8.GetBytes(data);
                encodedData = HttpUtility.UrlEncode(Convert.ToBase64String(data_byte));
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return encodedData;
        }
        public static string decodificarSenha(string senhaCodificada)
        {
            string data = senhaCodificada;
            string decodedData = String.Empty;
            try
            {
                byte[] data_byte = Convert.FromBase64String(HttpUtility.UrlDecode(data));
                decodedData = Encoding.UTF8.GetString(data_byte);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return decodedData;
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            string conexao = ConexaoBD.testeConexao();
            
                MessageBox.Show(conexao);
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tpServidor.Controls)
            {


                if (ctrl is TextBox)
                {
                    if (ctrl.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos!");
                        return;
                    }
                }


            }




            string enderecoBanco = txtEnderecoServer.Text;
            if (enderecoBanco.Contains(",") == false)
            {
                enderecoBanco += ",1433";
            }

            string configBanco = enderecoBanco + "|" + txtNomeBanco.Text + "|" + txtSenhaBanco.Text;
            string code = codificarSenha(configBanco);
            StreamWriter sw = new StreamWriter(Application.StartupPath + "/IPServerBOXCRM.id");
            try
            {
                sw.Write(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            sw.Close();
            ConexaoBanco.ConexaoBD.enderecoServidor = txtEnderecoServer.Text;
            ConexaoBanco.ConexaoBD.dbServidor = txtNomeBanco.Text;
            ConexaoBanco.ConexaoBD.senhaServidor = txtSenhaBanco.Text;
            Login.bancoConfigurado = true;
            System.Windows.Forms.MessageBox.Show(configBanco);

        }

        private void ConfiguracaoBanco_Load(object sender, EventArgs e)
        {


            txtEnderecoServer.Text = enderecoServer;
            txtNomeBanco.Text = nomeBanco;
            txtSenhaBanco.Text = senhaBanco;







        }
    }
}
