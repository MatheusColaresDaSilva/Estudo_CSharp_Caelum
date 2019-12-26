using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoForm
{
    class SeguroDeVida : ITributavel
    {
        public double CalcularTributos()
        {
            return 42;
        }
    }
}
