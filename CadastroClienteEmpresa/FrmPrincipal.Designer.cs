namespace CadastroClienteEmpresa
{
    partial class FrmPrincipal
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
            this.grpBoxEscolha = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rdBtnEmpresa = new System.Windows.Forms.RadioButton();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.rdBtnCliente = new System.Windows.Forms.RadioButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grpBoxEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxEscolha
            // 
            this.grpBoxEscolha.Controls.Add(this.btnCadastrar);
            this.grpBoxEscolha.Controls.Add(this.rdBtnEmpresa);
            this.grpBoxEscolha.Controls.Add(this.lblEmpresa);
            this.grpBoxEscolha.Controls.Add(this.rdBtnCliente);
            this.grpBoxEscolha.Controls.Add(this.lblCliente);
            this.grpBoxEscolha.Location = new System.Drawing.Point(4, 12);
            this.grpBoxEscolha.Name = "grpBoxEscolha";
            this.grpBoxEscolha.Size = new System.Drawing.Size(138, 124);
            this.grpBoxEscolha.TabIndex = 0;
            this.grpBoxEscolha.TabStop = false;
            this.grpBoxEscolha.Text = "Escolha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(31, 93);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar!";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rdBtnEmpresa
            // 
            this.rdBtnEmpresa.AutoSize = true;
            this.rdBtnEmpresa.Location = new System.Drawing.Point(83, 52);
            this.rdBtnEmpresa.Name = "rdBtnEmpresa";
            this.rdBtnEmpresa.Size = new System.Drawing.Size(14, 13);
            this.rdBtnEmpresa.TabIndex = 3;
            this.rdBtnEmpresa.TabStop = true;
            this.rdBtnEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(17, 52);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // rdBtnCliente
            // 
            this.rdBtnCliente.AutoSize = true;
            this.rdBtnCliente.Location = new System.Drawing.Point(83, 21);
            this.rdBtnCliente.Name = "rdBtnCliente";
            this.rdBtnCliente.Size = new System.Drawing.Size(14, 13);
            this.rdBtnCliente.TabIndex = 1;
            this.rdBtnCliente.TabStop = true;
            this.rdBtnCliente.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 140);
            this.Controls.Add(this.grpBoxEscolha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Cadastro";
            this.grpBoxEscolha.ResumeLayout(false);
            this.grpBoxEscolha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEscolha;
        private System.Windows.Forms.RadioButton rdBtnEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.RadioButton rdBtnCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

