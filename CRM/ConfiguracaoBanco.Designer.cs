
namespace CRM
{
    partial class ConfiguracaoBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracaoBanco));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlConfigServers = new System.Windows.Forms.TabControl();
            this.tpServidor = new System.Windows.Forms.TabPage();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.lblSenhaBanco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaBanco = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.txtEnderecoServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPlanet = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControlConfigServers.SuspendLayout();
            this.tpServidor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 69);
            this.panel1.TabIndex = 10;
            // 
            // tabControlConfigServers
            // 
            this.tabControlConfigServers.Controls.Add(this.tpServidor);
            this.tabControlConfigServers.Controls.Add(this.tpPlanet);
            this.tabControlConfigServers.Location = new System.Drawing.Point(12, 75);
            this.tabControlConfigServers.Name = "tabControlConfigServers";
            this.tabControlConfigServers.SelectedIndex = 0;
            this.tabControlConfigServers.Size = new System.Drawing.Size(603, 272);
            this.tabControlConfigServers.TabIndex = 11;
            // 
            // tpServidor
            // 
            this.tpServidor.Controls.Add(this.btnTesteConexao);
            this.tpServidor.Controls.Add(this.lblSenhaBanco);
            this.tpServidor.Controls.Add(this.label2);
            this.tpServidor.Controls.Add(this.txtSenhaBanco);
            this.tpServidor.Controls.Add(this.txtNomeBanco);
            this.tpServidor.Controls.Add(this.txtEnderecoServer);
            this.tpServidor.Controls.Add(this.label1);
            this.tpServidor.Location = new System.Drawing.Point(4, 24);
            this.tpServidor.Name = "tpServidor";
            this.tpServidor.Padding = new System.Windows.Forms.Padding(3);
            this.tpServidor.Size = new System.Drawing.Size(595, 244);
            this.tpServidor.TabIndex = 0;
            this.tpServidor.Text = "Teste Conexão";
            this.tpServidor.UseVisualStyleBackColor = true;
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(475, 33);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(108, 42);
            this.btnTesteConexao.TabIndex = 6;
            this.btnTesteConexao.Text = "Teste Conexão";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // lblSenhaBanco
            // 
            this.lblSenhaBanco.AutoSize = true;
            this.lblSenhaBanco.Location = new System.Drawing.Point(19, 114);
            this.lblSenhaBanco.Name = "lblSenhaBanco";
            this.lblSenhaBanco.Size = new System.Drawing.Size(42, 15);
            this.lblSenhaBanco.TabIndex = 5;
            this.lblSenhaBanco.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do banco:";
            // 
            // txtSenhaBanco
            // 
            this.txtSenhaBanco.Location = new System.Drawing.Point(19, 132);
            this.txtSenhaBanco.Name = "txtSenhaBanco";
            this.txtSenhaBanco.Size = new System.Drawing.Size(279, 23);
            this.txtSenhaBanco.TabIndex = 3;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(19, 88);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(279, 23);
            this.txtNomeBanco.TabIndex = 2;
            // 
            // txtEnderecoServer
            // 
            this.txtEnderecoServer.Location = new System.Drawing.Point(19, 44);
            this.txtEnderecoServer.Name = "txtEnderecoServer";
            this.txtEnderecoServer.Size = new System.Drawing.Size(279, 23);
            this.txtEnderecoServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço servidor local:";
            // 
            // tpPlanet
            // 
            this.tpPlanet.Location = new System.Drawing.Point(4, 24);
            this.tpPlanet.Name = "tpPlanet";
            this.tpPlanet.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlanet.Size = new System.Drawing.Size(595, 244);
            this.tpPlanet.TabIndex = 1;
            this.tpPlanet.Text = "Servidor BOXPDV";
            this.tpPlanet.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Location = new System.Drawing.Point(-4, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 53);
            this.panel2.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(387, 14);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(196, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ConfiguracaoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlConfigServers);
            this.Controls.Add(this.panel1);
            this.Name = "ConfiguracaoBanco";
            this.Text = "ConfiguracaoBanco";
            this.Load += new System.EventHandler(this.ConfiguracaoBanco_Load);
            this.tabControlConfigServers.ResumeLayout(false);
            this.tpServidor.ResumeLayout(false);
            this.tpServidor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlConfigServers;
        private System.Windows.Forms.TabPage tpServidor;
        private System.Windows.Forms.TabPage tpPlanet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.Label lblSenhaBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.TextBox txtEnderecoServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaBanco;
    }
}