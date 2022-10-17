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

namespace TPI.formularios.Proveedores
{
    public partial class FrmConsultarProveedor : Form
    {
        public FrmConsultarProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAltaProveedor(1, new Proveedor()).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvProveedor.CurrentRow;
            if (fila != null)
            {
                new FrmAltaProveedor(2, Mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvProveedor.CurrentRow;
            if (fila != null)
            {
                new FrmAltaProveedor(3, Mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            GestorProveedores gestor = new GestorProveedores();
            List<Proveedor> lista = gestor.ConsultarProveedorFiltro(txtNombre.Text, chkActivo.Checked);
            dgvProveedor.Rows.Clear();
            if (lista.Count > 0)
            {
                foreach (Proveedor oProveedor in lista)
                {
                    dgvProveedor.Rows.Add(new object[] { oProveedor.Codigo, oProveedor.Nombre, oProveedor.Telefono, oProveedor.Mail, oProveedor.Direccion, oProveedor.Activo });
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

        private Proveedor Mapper(DataGridViewRow fila)
        {
            Proveedor oSelected = new Proveedor();
            oSelected.Nombre = fila.Cells["ColNombre"].Value.ToString();
            oSelected.Codigo = (int)fila.Cells["ColCod"].Value;
            oSelected.Direccion = fila.Cells["ColDireccion"].Value.ToString();
            oSelected.Telefono = fila.Cells["ColTelefono"].Value.ToString();
            oSelected.Mail = fila.Cells["ColMail"].Value.ToString();           
            oSelected.Activo = (bool)fila.Cells["ColActivo"].Value;

            return oSelected;

        }
    }
}
