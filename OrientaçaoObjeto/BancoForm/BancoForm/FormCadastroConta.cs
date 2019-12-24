using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoForm
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            
            InitializeComponent();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            this.cBoxTipoConta.Items.Add("Conta Normal");
            this.cBoxTipoConta.Items.Add("Conta Corrente");
            this.cBoxTipoConta.Items.Add("Conta Poupança");
        }

        private void btnNovoConta_Click(object sender, EventArgs e)
        {

            int tpConta = cBoxTipoConta.SelectedIndex;
            Conta novaConta;
            switch (tpConta)
            {
                case 0:
                    novaConta = new Conta();
                break;

                case 1:
                    novaConta = new ContaCorrente();
                break;

                case 2:
                    novaConta = new ContaPoupanca();
                break;

                default:
                    novaConta = new Conta();
                break;
            }
                       
            novaConta.Titular = new Cliente(txtBoxNomeTitular.Text);
            novaConta.Numero = Convert.ToInt32(txtBoxNumeroConta.Text);

            this.formPrincipal.adicionaConta(novaConta);
            this.Close();

        }


    }
}
