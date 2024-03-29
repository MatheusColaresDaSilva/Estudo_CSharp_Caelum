﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;
using Banco.Interface;

namespace Banco.Totalizadores
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }
        public double tributoTotal { get; private set; }

        public void Adicona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }

        public void adiconaTibutoTotal(ITributavel itributavel)
        {
            this.tributoTotal += itributavel.CalcularTributos();
        }
    }
}
