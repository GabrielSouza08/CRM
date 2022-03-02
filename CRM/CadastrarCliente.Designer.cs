
namespace CRM
{
    partial class CadastrarLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarLoja));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblNomefantasia = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnContatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(26, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.DoubleClick += new System.EventHandler(this.txtCodigo_DoubleClick);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.White;
            this.txtCNPJ.Location = new System.Drawing.Point(106, 34);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(152, 23);
            this.txtCNPJ.TabIndex = 1;
            this.txtCNPJ.TextChanged += new System.EventHandler(this.txtCNPJ_TextChanged);
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // txtRazao
            // 
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Location = new System.Drawing.Point(26, 90);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(327, 23);
            this.txtRazao.TabIndex = 3;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Location = new System.Drawing.Point(359, 90);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(271, 23);
            this.txtNomeFantasia.TabIndex = 4;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(26, 139);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 23);
            this.txtCEP.TabIndex = 5;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(132, 139);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(389, 23);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(527, 139);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(103, 23);
            this.txtNumero.TabIndex = 7;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(26, 188);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(212, 23);
            this.txtComplemento.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(244, 188);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(245, 23);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(26, 233);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(212, 23);
            this.txtCidade.TabIndex = 10;
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Location = new System.Drawing.Point(244, 233);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(45, 23);
            this.txtUF.TabIndex = 12;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(26, 279);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(45, 23);
            this.txtDDD.TabIndex = 16;
            this.txtDDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDD_KeyPress);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(81, 279);
            this.txtTelefone.MaxLength = 10;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(157, 23);
            this.txtTelefone.TabIndex = 17;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(244, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.Blue;
            this.lblCodigo.Location = new System.Drawing.Point(26, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 15);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Código";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCNPJ.ForeColor = System.Drawing.Color.Blue;
            this.lblCNPJ.Location = new System.Drawing.Point(106, 16);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 15);
            this.lblCNPJ.TabIndex = 20;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRazao.ForeColor = System.Drawing.Color.Blue;
            this.lblRazao.Location = new System.Drawing.Point(26, 72);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(74, 15);
            this.lblRazao.TabIndex = 22;
            this.lblRazao.Text = "Razão Social";
            // 
            // lblNomefantasia
            // 
            this.lblNomefantasia.AutoSize = true;
            this.lblNomefantasia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomefantasia.ForeColor = System.Drawing.Color.Blue;
            this.lblNomefantasia.Location = new System.Drawing.Point(359, 72);
            this.lblNomefantasia.Name = "lblNomefantasia";
            this.lblNomefantasia.Size = new System.Drawing.Size(86, 15);
            this.lblNomefantasia.TabIndex = 23;
            this.lblNomefantasia.Text = "Nome Fantasia";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.lblEndereco.Location = new System.Drawing.Point(132, 121);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 15);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCEP.ForeColor = System.Drawing.Color.Blue;
            this.lblCEP.Location = new System.Drawing.Point(26, 121);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(27, 15);
            this.lblCEP.TabIndex = 25;
            this.lblCEP.Text = "CEP";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplemento.ForeColor = System.Drawing.Color.Blue;
            this.lblComplemento.Location = new System.Drawing.Point(26, 170);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(83, 15);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.Color.Blue;
            this.lblNumero.Location = new System.Drawing.Point(527, 121);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "Número";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.Blue;
            this.lblTelefone.Location = new System.Drawing.Point(81, 261);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 15);
            this.lblTelefone.TabIndex = 30;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDDD.ForeColor = System.Drawing.Color.Blue;
            this.lblDDD.Location = new System.Drawing.Point(26, 261);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(34, 15);
            this.lblDDD.TabIndex = 31;
            this.lblDDD.Text = "DDD";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUF.ForeColor = System.Drawing.Color.Blue;
            this.lblUF.Location = new System.Drawing.Point(244, 215);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 15);
            this.lblUF.TabIndex = 32;
            this.lblUF.Text = "UF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.Color.Blue;
            this.lblCidade.Location = new System.Drawing.Point(26, 214);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 15);
            this.lblCidade.TabIndex = 34;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.ForeColor = System.Drawing.Color.Blue;
            this.lblBairro.Location = new System.Drawing.Point(244, 170);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 15);
            this.lblBairro.TabIndex = 37;
            this.lblBairro.Text = "Bairro";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(257, 427);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(359, 427);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblemail.ForeColor = System.Drawing.Color.Blue;
            this.lblemail.Location = new System.Drawing.Point(244, 261);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(235, 15);
            this.lblemail.TabIndex = 29;
            this.lblemail.Text = "E-mail(s) - Separados por ponto e vírgula(;)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.AccessibleName = "";
            this.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacoes.Location = new System.Drawing.Point(26, 335);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(592, 77);
            this.txtObservacoes.TabIndex = 41;
            // 
            // btnContatos
            // 
            this.btnContatos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContatos.Enabled = false;
            this.btnContatos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnContatos.Image = ((System.Drawing.Image)(resources.GetObject("btnContatos.Image")));
            this.btnContatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContatos.Location = new System.Drawing.Point(506, 188);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(166, 48);
            this.btnContatos.TabIndex = 42;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContatos.UseVisualStyleBackColor = false;
            this.btnContatos.Visible = false;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // CadastrarLoja
            // 
            this.AccessibleName = "txtObservacoes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 539);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNomefantasia);
            this.Controls.Add(this.lblRazao);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtCodigo);
            this.Name = "CadastrarLoja";
            this.Text = "Detalhes do Cliente";
            this.Load += new System.EventHandler(this.frmCadastrarloja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblNomefantasia;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnContatos;
    }
}