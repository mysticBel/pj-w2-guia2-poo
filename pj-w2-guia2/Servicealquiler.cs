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

        //Constructor - inicializa el nro de dias, si el usuario no registra el nro 
        // de dias alquilados, se asignará como 1 
        public Servicealquiler(){
            this.numDias = 1;
        }

        //2.calcular el subtotal a pagar por los días alquilados,
        public double calcularSubtotal() { 
            return numDias * asignarPrecio();
        }

        //3. calcular el dscto del 5% todos los equipos solo para la sede central.
        //-no se ingresa el precio, ya se tiene una tabla de precios
        public double calcularDescuento(){
            return 0.05 * calcularSubtotal();
        }

        //Calcular neto
        public double calcularNeto() {
            return calcularSubtotal() - calcularDescuento();
        }

    }
}
