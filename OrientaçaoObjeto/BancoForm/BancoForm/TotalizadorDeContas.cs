using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoForm
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void Adicona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }
}
