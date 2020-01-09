using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Execoes;
using Banco.Interface;
using Banco.Pessoas;
using Banco.Busca;

namespace BancoForm
{
    public partial class FormCadastroConta : Form
    {

        private ICollection<string> devedores;
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
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
                    novaConta = new ContaCorrente();
                break;

                case 1:
                    novaConta = new ContaPoupanca();
                break;

                default:
                    novaConta = new ContaCorrente();
                break;
            }

            bool ehDevedor = this.devedores.Contains(txtBoxNomeTitular.Text);

            if (!ehDevedor)
            {
                novaConta.Titular = new Cliente(txtBoxNomeTitular.Text);
                novaConta.Numero = Convert.ToInt32(txtBoxNumeroConta.Text);

                this.formPrincipal.adicionaConta(novaConta);
                this.Close();
            }
            else
            {
                MessageBox.Show("devedor");
            }

        }


    }
}
