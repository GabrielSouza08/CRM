
namespace CRM
{
    partial class CadastroUsuarios
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
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAlerarSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbAlterarSenha = new System.Windows.Forms.GroupBox();
            this.optSim = new System.Windows.Forms.RadioButton();
            this.optNao = new System.Windows.Forms.RadioButton();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.gpbAlterarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.ColumnHeadersVisible = false;
            this.dgUsuarios.Location = new System.Drawing.Point(12, 24);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersVisible = false;
            this.dgUsuarios.RowTemplate.Height = 25;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(296, 202);
            this.dgUsuarios.TabIndex = 0;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perfil";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "SUPORTE",
            "PROGRAMADOR"});
            this.cmbPerfil.Location = new System.Drawing.Point(474, 51);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 23);
            this.cmbPerfil.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(441, 258);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(204, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(321, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(338, 24);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(338, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 3;
            // 
            // txtAlerarSenha
            // 
            this.txtAlerarSenha.Enabled = false;
            this.txtAlerarSenha.Location = new System.Drawing.Point(51, 56);
            this.txtAlerarSenha.Name = "txtAlerarSenha";
            this.txtAlerarSenha.PasswordChar = '*';
            this.txtAlerarSenha.Size = new System.Drawing.Size(129, 23);
            this.txtAlerarSenha.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Senha";
            // 
            // gpbAlterarSenha
            // 
            this.gpbAlterarSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbAlterarSenha.Controls.Add(this.optSim);
            this.gpbAlterarSenha.Controls.Add(this.optNao);
            this.gpbAlterarSenha.Controls.Add(this.txtAlerarSenha);
            this.gpbAlterarSenha.Controls.Add(this.label1);
            this.gpbAlterarSenha.Location = new System.Drawing.Point(338, 100);
            this.gpbAlterarSenha.Name = "gpbAlterarSenha";
            this.gpbAlterarSenha.Size = new System.Drawing.Size(296, 106);
            this.gpbAlterarSenha.TabIndex = 10;
            this.gpbAlterarSenha.TabStop = false;
            this.gpbAlterarSenha.Text = "Alterar Senha";
            // 
            // optSim
            // 
            this.optSim.AutoSize = true;
            this.optSim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.optSim.Location = new System.Drawing.Point(23, 22);
            this.optSim.Name = "optSim";
            this.optSim.Size = new System.Drawing.Size(45, 19);
            this.optSim.TabIndex = 11;
            this.optSim.Text = "Sim";
            this.optSim.UseVisualStyleBackColor = true;
            this.optSim.Click += new System.EventHandler(this.optSim_Click);
            // 
            // optNao
            // 
            this.optNao.AutoSize = true;
            this.optNao.Checked = true;
            this.optNao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.optNao.Location = new System.Drawing.Point(87, 22);
            this.optNao.Name = "optNao";
            this.optNao.Size = new System.Drawing.Size(48, 19);
            this.optNao.TabIndex = 10;
            this.optNao.TabStop = true;
            this.optNao.Text = "Não";
            this.optNao.UseVisualStyleBackColor = true;
            this.optNao.Click += new System.EventHandler(this.optNao_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.AutoSize = true;
            this.btnAlterarSenha.Enabled = false;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAlterarSenha.Location = new System.Drawing.Point(524, 156);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(91, 25);
            this.btnAlterarSenha.TabIndex = 11;
            this.btnAlterarSenha.Text = "Salvar";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 293);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.gpbAlterarSenha);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dgUsuarios);
            this.Name = "CadastroUsuarios";
            this.Text = "CadastroUsuarios";
            this.Load += new System.EventHandler(this.CadastroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.gpbAlterarSenha.ResumeLayout(false);
            this.gpbAlterarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAlerarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbAlterarSenha;
        private System.Windows.Forms.RadioButton optSim;
        private System.Windows.Forms.RadioButton optNao;
        private System.Windows.Forms.Button btnAlterarSenha;
    }
}