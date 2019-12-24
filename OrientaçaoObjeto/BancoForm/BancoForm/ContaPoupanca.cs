using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoForm
{
    class ContaPoupanca : Conta
    {
        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public override bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.10;
                return true;
            }
            return false;
        }
    }
}
