using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj_w2_guia2
{
    internal class PlazaNorte: Servicealquiler
    {
        public override double calcularDescuento()
        {
            if (numDias > 5) { 
                return 0.10 * calcularSubtotal();
            }
            return 0; 
        }
    }
}
