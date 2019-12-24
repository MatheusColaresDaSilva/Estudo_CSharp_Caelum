namespace BancoForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabBanco = new System.Windows.Forms.TabControl();
            this.pageSacaDeposita = new System.Windows.Forms.TabPage();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.gBoxBuscaConta = new System.Windows.Forms.GroupBox();
            this.cBoxEscolheConta = new System.Windows.Forms.ComboBox();
            this.btnBuscarConta = new System.Windows.Forms.Button();
            this.txtBuscarConta = new System.Windows.Forms.TextBox();
            this.lblEscolhaConta = new System.Windows.Forms.Label();
            this.gBoxTotalizadot = new System.Windows.Forms.GroupBox();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.textoTotalizador = new System.Windows.Forms.TextBox();
            this.gBoxConta = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.lblValorDeposito = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.pageTransferir = new System.Windows.Forms.TabPage();
            this.gBoxTransferir = new System.Windows.Forms.GroupBox();
            this.lblContaDestino = new System.Windows.Forms.Label();
            this.lblValorTransferir = new System.Windows.Forms.Label();
            this.txtValorTransferir = new System.Windows.Forms.TextBox();
            this.cBoxContaDestino = new System.Windows.Forms.ComboBox();
            this.cBoxContaOrigem = new System.Windows.Forms.ComboBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblContaOrigem = new System.Windows.Forms.Label();
            this.tabBanco.SuspendLayout();
            this.pageSacaDeposita.SuspendLayout();
            this.gBoxBuscaConta.SuspendLayout();
            this.gBoxTotalizadot.SuspendLayout();
            this.gBoxConta.SuspendLayout();
            this.pageTransferir.SuspendLayout();
            this.gBoxTransferir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBanco
            // 
            this.tabBanco.Controls.Add(this.pageSacaDeposita);
            this.tabBanco.Controls.Add(this.pageTransferir);
            this.tabBanco.Location = new System.Drawing.Point(0, 0);
            this.tabBanco.Name = "tabBanco";
            this.tabBanco.SelectedIndex = 0;
            this.tabBanco.Size = new System.Drawing.Size(471, 349);
            this.tabBanco.TabIndex = 10;
            // 
            // pageSacaDeposita
            // 
            this.pageSacaDeposita.Controls.Add(this.btnNovaConta);
            this.pageSacaDeposita.Controls.Add(this.gBoxBuscaConta);
            this.pageSacaDeposita.Controls.Add(this.gBoxTotalizadot);
            this.pageSacaDeposita.Controls.Add(this.gBoxConta);
            this.pageSacaDeposita.Location = new System.Drawing.Point(4, 22);
            this.pageSacaDeposita.Name = "pageSacaDeposita";
            this.pageSacaDeposita.Padding = new System.Windows.Forms.Padding(3);
            this.pageSacaDeposita.Size = new System.Drawing.Size(463, 323);
            this.pageSacaDeposita.TabIndex = 0;
            this.pageSacaDeposita.Text = "Aba 1";
            this.pageSacaDeposita.UseVisualStyleBackColor = true;
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(6, 278);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConta.TabIndex = 14;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // gBoxBuscaConta
            // 
            this.gBoxBuscaConta.Controls.Add(this.cBoxEscolheConta);
            this.gBoxBuscaConta.Controls.Add(this.btnBuscarConta);
            this.gBoxBuscaConta.Controls.Add(this.txtBuscarConta);
            this.gBoxBuscaConta.Controls.Add(this.lblEscolhaConta);
            this.gBoxBuscaConta.Location = new System.Drawing.Point(6, 6);
            this.gBoxBuscaConta.Name = "gBoxBuscaConta";
            this.gBoxBuscaConta.Size = new System.Drawing.Size(393, 71);
            this.gBoxBuscaConta.TabIndex = 9;
            this.gBoxBuscaConta.TabStop = false;
            this.gBoxBuscaConta.Text = "Busca de Conta";
            // 
            // cBoxEscolheConta
            // 
            this.cBoxEscolheConta.FormattingEnabled = true;
            this.cBoxEscolheConta.Location = new System.Drawing.Point(117, 44);
            this.cBoxEscolheConta.Name = "cBoxEscolheConta";
            this.cBoxEscolheConta.Size = new System.Drawing.Size(121, 21);
            this.cBoxEscolheConta.TabIndex = 13;
            this.cBoxEscolheConta.SelectedIndexChanged += new System.EventHandler(this.cBoxEscolheConta_SelectedIndexChanged);
            // 
            // btnBuscarConta
            // 
            this.btnBuscarConta.Location = new System.Drawing.Point(242, 27);
            this.btnBuscarConta.Name = "btnBuscarConta";
            this.btnBuscarConta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarConta.TabIndex = 12;
            this.btnBuscarConta.Text = "Buscar";
            this.btnBuscarConta.UseVisualStyleBackColor = true;
            this.btnBuscarConta.Click += new System.EventHandler(this.btnBuscarConta_Click);
            // 
            // txtBuscarConta
            // 
            this.txtBuscarConta.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarConta.Location = new System.Drawing.Point(117, 19);
            this.txtBuscarConta.Name = "txtBuscarConta";
            this.txtBuscarConta.Size = new System.Drawing.Size(119, 20);
            this.txtBuscarConta.TabIndex = 11;
            this.txtBuscarConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEscolhaConta
            // 
            this.lblEscolhaConta.AutoSize = true;
            this.lblEscolhaConta.Location = new System.Drawing.Point(26, 32);
            this.lblEscolhaConta.Name = "lblEscolhaConta";
            this.lblEscolhaConta.Size = new System.Drawing.Size(85, 13);
            this.lblEscolhaConta.TabIndex = 10;
            this.lblEscolhaConta.Text = "Escolha a Conta";
            // 
            // gBoxTotalizadot
            // 
            this.gBoxTotalizadot.Controls.Add(this.lblTotalSaldo);
            this.gBoxTotalizadot.Controls.Add(this.textoTotalizador);
            this.gBoxTotalizadot.Location = new System.Drawing.Point(269, 135);
            this.gBoxTotalizadot.Name = "gBoxTotalizadot";
            this.gBoxTotalizadot.Size = new System.Drawing.Size(142, 95);
            this.gBoxTotalizadot.TabIndex = 8;
            this.gBoxTotalizadot.TabStop = false;
            this.gBoxTotalizadot.Text = "Totalizador";
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Location = new System.Drawing.Point(3, 26);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(133, 13);
            this.lblTotalSaldo.TabIndex = 1;
            this.lblTotalSaldo.Text = "Total de Saldo Depositado";
            // 
            // textoTotalizador
            // 
            this.textoTotalizador.Enabled = false;
            this.textoTotalizador.Location = new System.Drawing.Point(15, 45);
            this.textoTotalizador.Name = "textoTotalizador";
            this.textoTotalizador.Size = new System.Drawing.Size(100, 20);
            this.textoTotalizador.TabIndex = 0;
            // 
            // gBoxConta
            // 
            this.gBoxConta.Controls.Add(this.lblSaldo);
            this.gBoxConta.Controls.Add(this.lblConta);
            this.gBoxConta.Controls.Add(this.lblTitular);
            this.gBoxConta.Controls.Add(this.textoTitular);
            this.gBoxConta.Controls.Add(this.lblValorDeposito);
            this.gBoxConta.Controls.Add(this.btnSacar);
            this.gBoxConta.Controls.Add(this.textoNumero);
            this.gBoxConta.Controls.Add(this.btnDepositar);
            this.gBoxConta.Controls.Add(this.textoSaldo);
            this.gBoxConta.Controls.Add(this.textoValor);
            this.gBoxConta.Location = new System.Drawing.Point(6, 83);
            this.gBoxConta.Name = "gBoxConta";
            this.gBoxConta.Size = new System.Drawing.Size(257, 189);
            this.gBoxConta.TabIndex = 7;
            this.gBoxConta.TabStop = false;
            this.gBoxConta.Text = "Conta";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(34, 78);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(33, 52);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 8;
            this.lblConta.Text = "Conta";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(33, 26);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 7;
            this.lblTitular.Text = "Titular";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(73, 19);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(169, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // lblValorDeposito
            // 
            this.lblValorDeposito.AutoSize = true;
            this.lblValorDeposito.Location = new System.Drawing.Point(45, 117);
            this.lblValorDeposito.Name = "lblValorDeposito";
            this.lblValorDeposito.Size = new System.Drawing.Size(34, 13);
            this.lblValorDeposito.TabIndex = 4;
            this.lblValorDeposito.Text = "Valor ";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(85, 136);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 6;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(73, 45);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(169, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(167, 136);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(73, 71);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(169, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(85, 110);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(157, 20);
            this.textoValor.TabIndex = 3;
            // 
            // pageTransferir
            // 
            this.pageTransferir.Controls.Add(this.gBoxTransferir);
            this.pageTransferir.Location = new System.Drawing.Point(4, 22);
            this.pageTransferir.Name = "pageTransferir";
            this.pageTransferir.Padding = new System.Windows.Forms.Padding(3);
            this.pageTransferir.Size = new System.Drawing.Size(463, 323);
            this.pageTransferir.TabIndex = 1;
            this.pageTransferir.Text = "Aba 2";
            this.pageTransferir.UseVisualStyleBackColor = true;
            // 
            // gBoxTransferir
            // 
            this.gBoxTransferir.Controls.Add(this.lblContaDestino);
            this.gBoxTransferir.Controls.Add(this.lblValorTransferir);
            this.gBoxTransferir.Controls.Add(this.txtValorTransferir);
            this.gBoxTransferir.Controls.Add(this.cBoxContaDestino);
            this.gBoxTransferir.Controls.Add(this.cBoxContaOrigem);
            this.gBoxTransferir.Controls.Add(this.btnTransferir);
            this.gBoxTransferir.Controls.Add(this.lblContaOrigem);
            this.gBoxTransferir.Location = new System.Drawing.Point(8, 20);
            this.gBoxTransferir.Name = "gBoxTransferir";
            this.gBoxTransferir.Size = new System.Drawing.Size(339, 216);
            this.gBoxTransferir.TabIndex = 10;
            this.gBoxTransferir.TabStop = false;
            this.gBoxTransferir.Text = "Transferir";
            // 
            // lblContaDestino
            // 
            this.lblContaDestino.AutoSize = true;
            this.lblContaDestino.Location = new System.Drawing.Point(36, 68);
            this.lblContaDestino.Name = "lblContaDestino";
            this.lblContaDestino.Size = new System.Drawing.Size(124, 13);
            this.lblContaDestino.TabIndex = 17;
            this.lblContaDestino.Text = "Escolha a Conta Destino";
            // 
            // lblValorTransferir
            // 
            this.lblValorTransferir.AutoSize = true;
            this.lblValorTransferir.Location = new System.Drawing.Point(167, 117);
            this.lblValorTransferir.Name = "lblValorTransferir";
            this.lblValorTransferir.Size = new System.Drawing.Size(34, 13);
            this.lblValorTransferir.TabIndex = 16;
            this.lblValorTransferir.Text = "Valor ";
            // 
            // txtValorTransferir
            // 
            this.txtValorTransferir.Location = new System.Drawing.Point(207, 114);
            this.txtValorTransferir.Name = "txtValorTransferir";
            this.txtValorTransferir.Size = new System.Drawing.Size(77, 20);
            this.txtValorTransferir.TabIndex = 15;
            // 
            // cBoxContaDestino
            // 
            this.cBoxContaDestino.FormattingEnabled = true;
            this.cBoxContaDestino.Location = new System.Drawing.Point(163, 65);
            this.cBoxContaDestino.Name = "cBoxContaDestino";
            this.cBoxContaDestino.Size = new System.Drawing.Size(121, 21);
            this.cBoxContaDestino.TabIndex = 14;
            // 
            // cBoxContaOrigem
            // 
            this.cBoxContaOrigem.FormattingEnabled = true;
            this.cBoxContaOrigem.Location = new System.Drawing.Point(163, 29);
            this.cBoxContaOrigem.Name = "cBoxContaOrigem";
            this.cBoxContaOrigem.Size = new System.Drawing.Size(121, 21);
            this.cBoxContaOrigem.TabIndex = 13;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(209, 153);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 12;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblContaOrigem
            // 
            this.lblContaOrigem.AutoSize = true;
            this.lblContaOrigem.Location = new System.Drawing.Point(36, 32);
            this.lblContaOrigem.Name = "lblContaOrigem";
            this.lblContaOrigem.Size = new System.Drawing.Size(121, 13);
            this.lblContaOrigem.TabIndex = 10;
            this.lblContaOrigem.Text = "Escolha a Conta Origem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 350);
            this.Controls.Add(this.tabBanco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBanco.ResumeLayout(false);
            this.pageSacaDeposita.ResumeLayout(false);
            this.gBoxBuscaConta.ResumeLayout(false);
            this.gBoxBuscaConta.PerformLayout();
            this.gBoxTotalizadot.ResumeLayout(false);
            this.gBoxTotalizadot.PerformLayout();
            this.gBoxConta.ResumeLayout(false);
            this.gBoxConta.PerformLayout();
            this.pageTransferir.ResumeLayout(false);
            this.gBoxTransferir.ResumeLayout(false);
            this.gBoxTransferir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBanco;
        private System.Windows.Forms.TabPage pageSacaDeposita;
        private System.Windows.Forms.GroupBox gBoxBuscaConta;
        private System.Windows.Forms.ComboBox cBoxEscolheConta;
        private System.Windows.Forms.Button btnBuscarConta;
        private System.Windows.Forms.TextBox txtBuscarConta;
        private System.Windows.Forms.Label lblEscolhaConta;
        private System.Windows.Forms.GroupBox gBoxTotalizadot;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.TextBox textoTotalizador;
        private System.Windows.Forms.GroupBox gBoxConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label lblValorDeposito;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.TabPage pageTransferir;
        private System.Windows.Forms.GroupBox gBoxTransferir;
        private System.Windows.Forms.ComboBox cBoxContaOrigem;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label lblContaOrigem;
        private System.Windows.Forms.Label lblValorTransferir;
        private System.Windows.Forms.TextBox txtValorTransferir;
        private System.Windows.Forms.ComboBox cBoxContaDestino;
        private System.Windows.Forms.Label lblContaDestino;
        private System.Windows.Forms.Button btnNovaConta;
    }
}

