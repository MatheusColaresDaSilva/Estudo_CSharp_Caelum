namespace BancoForm
{
    partial class FormCadastroConta
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
            this.btnNovoConta = new System.Windows.Forms.Button();
            this.lblNomeTitular = new System.Windows.Forms.Label();
            this.txtBoxNomeTitular = new System.Windows.Forms.TextBox();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.txtBoxNumeroConta = new System.Windows.Forms.TextBox();
            this.cBoxTipoConta = new System.Windows.Forms.ComboBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovoConta
            // 
            this.btnNovoConta.Location = new System.Drawing.Point(140, 163);
            this.btnNovoConta.Name = "btnNovoConta";
            this.btnNovoConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovoConta.TabIndex = 0;
            this.btnNovoConta.Text = "Adicionar";
            this.btnNovoConta.UseVisualStyleBackColor = true;
            this.btnNovoConta.Click += new System.EventHandler(this.btnNovoConta_Click);
            // 
            // lblNomeTitular
            // 
            this.lblNomeTitular.AutoSize = true;
            this.lblNomeTitular.Location = new System.Drawing.Point(73, 127);
            this.lblNomeTitular.Name = "lblNomeTitular";
            this.lblNomeTitular.Size = new System.Drawing.Size(36, 13);
            this.lblNomeTitular.TabIndex = 2;
            this.lblNomeTitular.Text = "Titular";
            // 
            // txtBoxNomeTitular
            // 
            this.txtBoxNomeTitular.Location = new System.Drawing.Point(115, 124);
            this.txtBoxNomeTitular.Name = "txtBoxNomeTitular";
            this.txtBoxNomeTitular.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeTitular.TabIndex = 4;
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Location = new System.Drawing.Point(65, 73);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroConta.TabIndex = 1;
            this.lblNumeroConta.Text = "Numero";
            // 
            // txtBoxNumeroConta
            // 
            this.txtBoxNumeroConta.Location = new System.Drawing.Point(115, 66);
            this.txtBoxNumeroConta.Name = "txtBoxNumeroConta";
            this.txtBoxNumeroConta.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumeroConta.TabIndex = 3;
            // 
            // cBoxTipoConta
            // 
            this.cBoxTipoConta.FormattingEnabled = true;
            this.cBoxTipoConta.Location = new System.Drawing.Point(115, 97);
            this.cBoxTipoConta.Name = "cBoxTipoConta";
            this.cBoxTipoConta.Size = new System.Drawing.Size(99, 21);
            this.cBoxTipoConta.TabIndex = 5;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(35, 100);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(74, 13);
            this.lblTipoConta.TabIndex = 6;
            this.lblTipoConta.Text = "Tipo de Conta";
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 289);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.cBoxTipoConta);
            this.Controls.Add(this.txtBoxNomeTitular);
            this.Controls.Add(this.txtBoxNumeroConta);
            this.Controls.Add(this.lblNomeTitular);
            this.Controls.Add(this.lblNumeroConta);
            this.Controls.Add(this.btnNovoConta);
            this.Name = "FormCadastroConta";
            this.Text = "Cadastro Conta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoConta;
        private System.Windows.Forms.Label lblNomeTitular;
        private System.Windows.Forms.TextBox txtBoxNomeTitular;
        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.TextBox txtBoxNumeroConta;
        private System.Windows.Forms.ComboBox cBoxTipoConta;
        private System.Windows.Forms.Label lblTipoConta;
    }
}