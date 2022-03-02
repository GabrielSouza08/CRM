using System;
using System.IO;
using System.Windows.Forms;
using TransferenciaDados;

namespace CRM
{
    public partial class Login : Form
    {
        public static Boolean bancoConfigurado = false;
        
        public Login()
        {
            InitializeComponent();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "/IPServerBOXCRM.id"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "/IPServerBOXCRM.id");

                string linha, uLinha = string.Empty;
                linha = sr.ReadLine();
                sr.Close();
                uLinha = ConfiguracaoBanco.decodificarSenha(linha);
                string[] conf = uLinha.Split("|");

                ConexaoBanco.ConexaoBD.enderecoServidor = conf[0];
                ConexaoBanco.ConexaoBD.dbServidor = conf[1];
                ConexaoBanco.ConexaoBD.senhaServidor = conf[2];
                bancoConfigurado = true;
            }
            lblVersao.Text = Application.ProductVersion.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (bancoConfigurado)
            {

                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is TextBox)
                    {
                        if(ctrl.Text == "")
                        {
                            MessageBox.Show("Preencha todos os campos!");
                            return;
                        }
                    }
                }

                Usuario user = new Usuario();
                user.Nome = txtUsuario.Text;
                user.Senha = user.CriptografarSenha(txtSenha.Text);

                TransferenciaDados.Login log = new TransferenciaDados.Login();

                user = log.ValidarLogin(user);



                if (user.Nome != "")
                {
                    
                    HomeMonitor tela = new HomeMonitor();
                    tela.Show();
                    this.Close();


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Usuário ou senha incorretos!" + user.Senha);
                }
            }
            else
            {
                MessageBox.Show("O acesso ao banco não está configurado !");
            }
            
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfiguracaoBanco config = new ConfiguracaoBanco(ConexaoBanco.ConexaoBD.enderecoServidor,
            ConexaoBanco.ConexaoBD.dbServidor,
            ConexaoBanco.ConexaoBD.senhaServidor);
            config.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

