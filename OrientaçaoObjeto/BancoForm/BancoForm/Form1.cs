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
        private List<Conta> contas;
        private TotalizadorDeContas totalizador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.totalizador = new TotalizadorDeContas();
            this.contas = new List<Conta>();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas.ElementAt(indice);
            double valorDigitado = Convert.ToDouble(textoValor.Text);
            try
            {
                contaSelecionada.Deposita(valorDigitado);
                textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
                textoValor.Clear();
                MessageBox.Show("Sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Argumento Inválido");
            }
            
          
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas.ElementAt(indice);
            double valorDigitado = Convert.ToDouble(textoValor.Text);

            try
            {
                contaSelecionada.Saca(valorDigitado);
                textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
                textoValor.Clear();
                MessageBox.Show("Sucesso");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor inválido");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Inválido");
            }

           
        }

        private void btnBuscarConta_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(txtBuscarConta.Text);
            Conta contaSelecionada = this.contas.ElementAt(indice);

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void cBoxEscolheConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas.ElementAt(indice);

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            int indiceOrigem = cBoxContaOrigem.SelectedIndex;
            int indiceDestino = cBoxContaDestino.SelectedIndex;
            double valorDigitado = Convert.ToDouble(txtValorTransferir.Text);
            Conta contaOrigem = this.contas.ElementAt(indiceOrigem);
            Conta contaDestino = this.contas.ElementAt(indiceDestino);

            if(contaOrigem.Transfere(contaDestino, valorDigitado))
            {
                MessageBox.Show("Transferencia Realizada com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro na operação");
            }
        }

        public void adicionaConta(Conta conta)
        {
            this.contas.Add(conta);
//            cBoxEscolheConta.Items.Add("titular: " + conta.Titular.Nome);
            this.popularComboBox(cBoxEscolheConta, conta);
            this.popularComboBox(cBoxContaOrigem, conta);
            this.popularComboBox(cBoxContaDestino, conta);

        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formCadastroConta = new FormCadastroConta(this);
            formCadastroConta.ShowDialog();

        }

        private void popularComboBox(ComboBox cBox,Conta conta)
        {
            cBox.Items.Add(conta.Titular.Nome);
            
        }

        private void btnCalcularImposto_Click(object sender, EventArgs e)
        {
            int indice = cBoxEscolheConta.SelectedIndex;
            Conta contaSelecionada = this.contas.ElementAt(indice);

    
            if(contaSelecionada is ITributavel)
            {
                ITributavel t = (ITributavel) contaSelecionada;
                textoImposto.Text = Convert.ToString(t.CalcularTributos());
            }
            else
            {
                textoImposto.Clear();
                MessageBox.Show("Essa conta nao e tributavel");
            }

        }
    }
}
