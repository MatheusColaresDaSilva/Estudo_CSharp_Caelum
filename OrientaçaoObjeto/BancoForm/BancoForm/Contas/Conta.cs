using System;
using Banco.Pessoas;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public abstract void Deposita(double valor);

        public abstract bool Saca(double valor);

        public bool Transfere(Conta contaDestino, double valor)
        {
            if (this.Saca(valor))
            {
                contaDestino.Deposita(valor);
                return true;
            }

            return false;
        }
    }
}