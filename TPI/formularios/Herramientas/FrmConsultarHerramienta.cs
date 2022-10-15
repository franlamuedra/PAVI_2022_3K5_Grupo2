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

namespace TPI.formularios.Herramientas
{
    public partial class FrmConsultarHerramienta : Form
    {
        public FrmConsultarHerramienta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAltaHerramienta(1, new Herramienta()).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvHerramienta.CurrentRow;
            if (fila != null)
            {
                new FrmAltaHerramienta(2, Mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvHerramienta.CurrentRow;
            if (fila != null)
            {
                new FrmAltaHerramienta(3, Mapper(fila)).ShowDialog();
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
            GestorHerramientas gestor = new GestorHerramientas();
            List<Herramienta> lista = gestor.ConsultarHerramientaFiltro(txtMarca.Text, chkActivo.Checked);
            dgvHerramienta.Rows.Clear();
            if (lista.Count > 0)
            {
                foreach (Herramienta oHerramienta in lista)
                {
                    dgvHerramienta.Rows.Add(new object[] { oHerramienta.Codigo, oHerramienta.Codigo_Proveedor, oHerramienta.Marca, oHerramienta.Modelo, oHerramienta.Vida_Util, oHerramienta.Activo });
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

        private Herramienta Mapper(DataGridViewRow fila)
        {
            Herramienta oSelected = new Herramienta();
            oSelected.Marca = fila.Cells["ColMarca"].Value.ToString();
            oSelected.Codigo = (int)fila.Cells["ColCod"].Value;
            oSelected.Modelo = fila.Cells["ColModelo"].Value.ToString();
            oSelected.Vida_Util = (int)fila.Cells["ColVida"].Value;
            oSelected.Codigo_Proveedor = (int)fila.Cells["ColCodProv"].Value;
            oSelected.Activo = (bool)fila.Cells["ColActivo"].Value;

            return oSelected;

        }

    }
}
