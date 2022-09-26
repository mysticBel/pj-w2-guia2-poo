using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj_w2_guia2
{
    public partial class frmPlazaNorte : Form
    {
        int n; //variable global inicializada en 0

        public frmPlazaNorte()
        {
            InitializeComponent();
        }

        private void frmPlazaNorte_Load(object sender, EventArgs e)
        {
            cboEquipo.Items.Add("Teclado");
            cboEquipo.Items.Add("Monitor");
            cboEquipo.Items.Add("Mouse");
            cboEquipo.Items.Add("Proyector");
            generaNumero();
        }

        void generaNumero() {
            n++;
            lblNumero.Text = n.ToString("0000");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PlazaNorte objP = new PlazaNorte();
            objP.numAlquiler = int.Parse(lblNumero.Text);
            objP.equipo = cboEquipo.Text;
            //Si no registra dias, que se ejecute lo del constructor
            if (!txtDias.Text.Equals("")) 
            {
                objP.numDias = int.Parse(txtDias.Text);
            }
            

            double precio = objP.asignarPrecio();
            double subtotal = objP.calcularSubtotal();
            double descuento = objP.calcularDescuento();
            double neto = objP.calcularNeto();  

            //Nuevo objeto ObjP añadido a la tabla ListView
            ListViewItem fila = new ListViewItem(objP.numAlquiler.ToString());
            fila.SubItems.Add(objP.equipo);
            fila.SubItems.Add(objP.numDias.ToString());
            fila.SubItems.Add(precio.ToString("0.00"));
            fila.SubItems.Add(subtotal.ToString("0.00"));
            fila.SubItems.Add(descuento.ToString("0.00"));
            fila.SubItems.Add(neto.ToString("0.00"));
            lvAlquiler.Items.Add(fila);
        }
    }
}
