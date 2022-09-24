using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.dominio;

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
            DataGridViewRow fila = dgvMaterial.CurrentRow;
            if (fila != null)
            {
                new FrmAltaMaterial(3, mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FrmAltaMaterial frmAlta = new FrmAltaMaterial();
            //frmAlta.ShowDialog();
        }

        private Material mapper(DataGridViewRow fila)
        {
            Material oSelected = new Material();
            oSelected.Codigo = (int)fila.Cells["Codigo_Material"].Value;
            oSelected.Cantidad = (double)fila.Cells["Cantidad"].Value;
            oSelected.UnidadMedida = fila.Cells["Unidad_Medida"].Value.ToString();
            oSelected.FechaIngreso = (DateTime)fila.Cells["Fecha_Ingreso"].Value;
            //oSelected.ProveedorMa = (int)fila.Cells["Cod_Proveedor"].Value;

            return oSelected;

        }

    }
}
