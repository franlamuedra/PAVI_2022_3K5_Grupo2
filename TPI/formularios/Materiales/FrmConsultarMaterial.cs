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
using TPI.Servicios;

namespace TPI
{
    // int codigo_material, int cantidad, double unidad_medida, int codigo_proveedor, date fehca_ingreso 
    public partial class FrmConsultarMaterial : Form
    {
        public FrmConsultarMaterial()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAltaMaterial(1, new Material()).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvMaterial.CurrentRow;
            if (fila != null)
            {
                new FrmAltaMaterial(2, Mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {            
            GestorMateriales gestor = new GestorMateriales();
            List<Material> lista = gestor.ConsultarMaterialFiltro(txtNombre.Text, chkActivo.Checked);
            dgvMaterial.Rows.Clear();
            if (lista.Count > 0)
            {
                foreach (Material oMaterial in lista)
                {
                    dgvMaterial.Rows.Add(new object[] { oMaterial.Nombre, oMaterial.Codigo, oMaterial.Cantidad, oMaterial.UnidadMedida, oMaterial.FechaIngreso, oMaterial.ProveedorMa, oMaterial.Activo });
                }
                habilitarControles(true);
            }
            else
            {
                habilitarControles(false);
            }
        }
        

        private void habilitarControles(bool v)
        {
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvMaterial.CurrentRow;
            if (fila != null)
            {
                new FrmAltaMaterial(3, Mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private Material Mapper(DataGridViewRow fila)
        {
            Material oSelected = new Material();
            oSelected.Nombre = fila.Cells["ColNombre"].Value.ToString();
            oSelected.Codigo = (int)fila.Cells["ColCodigo"].Value;
            oSelected.Cantidad = (float)fila.Cells["ColCantidad"].Value;
            oSelected.UnidadMedida = fila.Cells["ColUnidad"].Value.ToString();
            oSelected.FechaIngreso = fila.Cells["ColFec"].Value.ToString();
            oSelected.ProveedorMa = (int)fila.Cells["ColProveedor"].Value;
            oSelected.Activo = (bool)fila.Cells["ColActivo"].Value;

            return oSelected;

        }

    }
}
