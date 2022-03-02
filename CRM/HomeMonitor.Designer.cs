
namespace CRM
{
    partial class HomeMonitor
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
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Location = new System.Drawing.Point(75, 12);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(210, 23);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(461, 12);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(210, 23);
            this.btnCadastrarUsuario.TabIndex = 1;
            this.btnCadastrarUsuario.Text = "Cadastro de Usuarios";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // HomeMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.btnCadastroCliente);
            this.Name = "HomeMonitor";
            this.Text = "HomeMonitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeMonitor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastrarUsuario;
    }
}