using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj_w2_guia2
{
    internal class Servicealquiler
    {
        public int numAlquiler { get; set; }
        public string equipo { get; set; }
        public int numDias { get; set; }


        // 1. Asignar el precio de alquiler
        public double asignarPrecio() {

            switch (equipo) 
            { 
                case "Teclado": return 20;
                case "Monitor": return 100;
                case "Mouse": return 20;
                case "Proyector": return 200;
            }
            return 0;
        }
    }
}
