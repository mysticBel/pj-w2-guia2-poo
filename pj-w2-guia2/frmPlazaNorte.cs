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
            objP.numDias = int.Parse(txtDias.Text);
        }
    }
}
