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
    public partial class Form1 : Form
    {
        //private ContaCorrente conta;
        private Conta[] contas;
        private TotalizadorDeContas totalizador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.totalizador = new TotalizadorDeContas();
            //this.conta = new ContaCorrente();
            this.contas = new Conta[3];
            
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("Mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("Osni");
            this.contas[2].Numero = 3;

            foreach (Conta conta in this.contas)
            {
                cBoxEscolheConta.Items.Add("Titular: " + conta.Titular.Nome);
                cBoxContaOrigem.Items.Add(conta.Numero);
                cBoxContaDestino.Items.Add(conta.Numero);
            }

            /*conta.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            conta.Titular = cliente;

            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);*/
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas[indice];

            double valorDigitado = Convert.ToDouble(textoValor.Text);
            contaSelecionada.Deposita(valorDigitado);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoValor.Clear();
            MessageBox.Show("Sucesso");

            totalizador.Adicona(contaSelecionada);
            textoTotalizador.Text = Convert.ToString(totalizador.SaldoTotal);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas[indice];

            double valorDigitado = Convert.ToDouble(textoValor.Text);
            
            if (contaSelecionada.Saca(valorDigitado)){
                textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
                textoValor.Clear();
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a operação");
            }
           
        }

        private void btnBuscarConta_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(txtBuscarConta.Text);
            Conta contaSelecionada = this.contas[indice];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void cBoxEscolheConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas[indice];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            int indiceOrigem = cBoxContaOrigem.SelectedIndex;
            int indiceDestino = cBoxContaDestino.SelectedIndex;
            double valorDigitado = Convert.ToDouble(txtValorTransferir.Text);
            Conta contaOrigem = this.contas[indiceOrigem];
            Conta contaDestino = this.contas[indiceDestino];

            if(contaOrigem.Transfere(contaDestino, valorDigitado))
            {
                MessageBox.Show("Transferencia Realizada com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro na operação");
            }
        }
    }
}
