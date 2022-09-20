using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI
{
    // int codigo_material, int cantidad, double unidad_medida, int codigo_proveedor, date fehca_ingreso 
    public partial class FrmConsultarMaterial : Form
    {
        public FrmConsultarMaterial()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaMaterial frmAlta = new FrmAltaMaterial();
            frmAlta.ShowDialog();
        }

    }
}
