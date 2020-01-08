using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Execoes;

namespace Banco.Contas
{
    class ContaPoupanca : Conta
    {
        public override void Deposita(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException();
            }

            this.Saldo += valor;
        }

        public override bool Saca(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
                
            }

            else if (this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.10;
                return true;
            }
            
            throw new SaldoInsuficienteException();
     
        }
    }
}
