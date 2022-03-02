using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Correios;
using System.Windows.Forms;
using TransferenciaDados;
using System.ServiceModel;


namespace CRM
{
    public partial class CadastrarLoja : Form
    {
        public static int ID { get; set; }

        public CadastrarLoja(int campoID)
        {
            InitializeComponent();
            ID = campoID;
        }
        private void frmCadastrarloja_Load(object sender, EventArgs e)
        {
            
            Lojas dados = new Lojas();
            dados.ID = ID;


            if (dados.ID != 0)
            {
                dados.PreencherCadastro(dados);
                if (ID != 0 && dados.Codigo != "")
                {
                    txtCodigo.Text = dados.Codigo;
                    txtCodigo.Enabled = false;
                }
               
                txtCNPJ.Text = dados.CNPJ;
                txtRazao.Text = dados.RazaoSocial;
                txtNomeFantasia.Text = dados.NomeFantasia;
                txtCEP.Text = dados.CEP;
                txtEndereco.Text = dados.Endereco;
                txtNumero.Text = dados.Numero;
                txtComplemento.Text = dados.Complemento;
                txtBairro.Text = dados.Bairro;
                txtUF.Text = dados.UF;
                if (dados.Telefone == "")
                {
                    txtDDD.Text = "";
                    txtTelefone.Text = "";

                }
                else
                {
                    txtDDD.Text = dados.Telefone.Substring(0, 2);
                    txtTelefone.Text = dados.Telefone.Substring(2, dados.Telefone.Length -2);
                }

                txtEmail.Text = dados.Email;
                txtObservacoes.Text = dados.OBSAdicionais;

                btnContatos.Enabled = true;
                btnContatos.Visible = true;
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Se o ID for igual a 0, é um cadastro novo, se nao for, é uma alteração
            if (ID == 0)
            {
                
                

                //Chamando o Objeto loja, que vai receber os  valores dos campos
                Lojas loja = new Lojas();
                if (ValidarCamposObrigatorios() == false)
                {
                    MessageBox.Show("Verifique o campo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                if (txtCodigo.TextLength != 0)
                {


                    if (loja.VerSeCodigoExiste(Convert.ToString(txtCodigo.Text)) == txtCodigo.Text)
                    {
                        MessageBox.Show("Codigo ja existente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                    }
                    else
                    {
                        loja.Codigo = txtCodigo.Text;
                    }


                }
                else
                {
                    loja.Codigo = "NULL";
                }
                loja.CNPJ = txtCNPJ.Text;
                if (loja.VerSeCNPJExiste(loja.CNPJ) == loja.CNPJ)
                {
                    MessageBox.Show("CNPJ JA CADASTRADO!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


                else
                {

                    try
                    {

                        loja.NomeFantasia = txtNomeFantasia.Text;
                        loja.RazaoSocial = txtRazao.Text;
                        loja.Endereco = txtEndereco.Text;

                        if (txtNumero.TextLength != 0)
                        {
                            loja.Numero = txtNumero.Text;
                        }
                        else
                        {
                            loja.Numero = "S/N";
                        }

                        loja.Bairro = txtBairro.Text;
                        loja.Municipio = txtCidade.Text;
                        loja.UF = txtUF.Text;
                        loja.CEP = txtCEP.Text;
                        loja.Telefone = txtDDD.Text + txtTelefone.Text;
                        loja.Email = txtEmail.Text;
                        loja.OBSAdicionais = txtObservacoes.Text;


                        loja.CadastrarLoja(loja);
                        MessageBox.Show("Inserido com sucesso!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCodigo.Text = "";
                        txtCNPJ.Text = "";
                        txtRazao.Text = "";
                        txtNomeFantasia.Text = "";
                        txtCEP.Text = "";
                        txtEndereco.Text = "";
                        txtNumero.Text = "";
                        txtComplemento.Text = "";
                        txtBairro.Text = "";
                        txtCidade.Text = "";
                        txtUF.Text = "";
                        txtDDD.Text = "";
                        txtTelefone.Text = "";
                        txtEmail.Text = "";
                        txtObservacoes.Text = "";



                    }


                    catch (System.IndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                try
                {
                    
                    Lojas loja = new Lojas();
                    loja.ID = ID;
                    if(txtCodigo.Text !="")
                    {
                        loja.Codigo = txtCodigo.Text;
                    }
                    else
                    {
                        loja.Codigo = "NULL";

                    }
                    loja.CNPJ = txtCNPJ.Text;
                    loja.NomeFantasia = txtNomeFantasia.Text;
                    loja.RazaoSocial = txtRazao.Text;
                    loja.Endereco = txtEndereco.Text;

                    if (txtNumero.TextLength != 0)
                    {
                        loja.Numero = txtNumero.Text;
                    }
                    else
                    {
                        loja.Numero = "S/N";
                    }

                    loja.Bairro = txtBairro.Text;
                    loja.Municipio = txtCidade.Text;
                    loja.UF = txtUF.Text;
                    loja.CEP = txtCEP.Text;
                    loja.Telefone = txtDDD.Text + txtTelefone.Text;
                    loja.Email = txtEmail.Text;
                    loja.OBSAdicionais = txtObservacoes.Text;


                    loja.EdtarLojas(loja);
                    MessageBox.Show("Cliente Alterado com sucesso!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigo.Text = "";
                    txtCNPJ.Text = "";
                    txtRazao.Text = "";
                    txtNomeFantasia.Text = "";
                    txtCEP.Text = "";
                    txtEndereco.Text = "";
                    txtNumero.Text = "";
                    txtComplemento.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtUF.Text = "";
                    txtDDD.Text = "";
                    txtTelefone.Text = "";
                    txtEmail.Text = "";
                    txtObservacoes.Text = "";



                }


                catch (System.IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
                finally
                {
                    this.Close();
                }
            }
            
            






        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {

            if (txtCNPJ.TextLength == 14)
            {
                txtCNPJ.Text = txtCNPJ.Text.Insert(2, ".");
                txtCNPJ.Text = txtCNPJ.Text.Insert(6, ".");
                txtCNPJ.Text = txtCNPJ.Text.Insert(10, "/");
                txtCNPJ.Text = txtCNPJ.Text.Insert(15, "-");

            }


            if (txtCNPJ.TextLength > 18)
            {
                MessageBox.Show("Valor digitado incorretamente, Verifique!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCNPJ.Text = "";
                txtCNPJ.Focus();
            }


        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.TextLength == 8)
            {


                CorreiosApi correiosApi = new CorreiosApi();

                try
                {
                    var retorno = correiosApi.consultaCEP(txtCEP.Text);
                    txtCEP.Text = retorno.cep;
                    txtEndereco.Text = retorno.end;
                    txtBairro.Text = retorno.bairro;
                    txtCidade.Text = retorno.cidade;
                    txtComplemento.Text = retorno.complemento;
                    txtUF.Text = retorno.uf;

                    txtCEP.Text = txtCEP.Text.Insert(5, "-");
                }

                catch (System.ServiceModel.FaultException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCEP.Text = "";
                    txtCEP.Focus();

                }


            }

        }


        private bool ValidarCamposObrigatorios()
        {

            if (txtCNPJ.TextLength == 0)
            {
                MessageBox.Show("CNPJ está vazio", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (txtRazao.TextLength.Equals(0))
            {
                MessageBox.Show("Razao Social inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
   
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.TextLength == 18)
            {
                if (IsCnpj(txtCNPJ.Text))
                {
                    txtRazao.Focus();

                }

                else
                {
                    MessageBox.Show("CNPJ digitado incorretamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCNPJ.Text = "";
                    txtCNPJ.Focus();

                }
            }  
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtCNPJ.Text = "";
            txtRazao.Text = "";
            txtNomeFantasia.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtUF.Text = "";
            txtDDD.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtObservacoes.Text = "";
        }

        private void txtDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtCodigo_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {

            ContatoClientes frm = new ContatoClientes(ID);
            frm.Show();

        }
    }
}