using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Interface;

namespace Banco.Totalizadores
{
    class SeguroDeVida : ITributavel
    {
        public double CalcularTributos()
        {
            return 42;
        }
    }
}
