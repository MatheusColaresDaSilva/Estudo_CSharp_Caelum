using System;

namespace BancoForm
{
    public class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; internal set; }

        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public virtual bool Transfere(Conta contaDestino, double valor)
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