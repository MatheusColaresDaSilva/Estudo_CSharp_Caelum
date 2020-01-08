using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoForm
{
    class ContaCorrente : Conta, ITributavel
    {
   
        public override void Deposita(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
            }

            this.Saldo += valor - 0.10;
        }

        public override bool Saca(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();

            }

            else if (this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.05;
                return true;
            }

            throw new SaldoInsuficienteException();

        }
        public double CalcularTributos()
        {
           return this.Saldo*0.05;
        }

    }
}
