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
using TPI.Servicios.Interfaz;

namespace TPI.formularios.Transacciones
{
    public partial class FrmConsultarAlquileres : Form
    {
        private IServicioAlquiler servicio;
        private FabricaServicioAlquiler fabrica;

        public FrmConsultarAlquileres(FabricaServicioAlquiler fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearServicioAlquiler();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvAlquiler.Rows.Clear();
            List<Alquiler> lst = servicio.ObtenerAlquileres(dtpDesde.Value, dtpHasta.Value);
            foreach (Alquiler alq in lst)
            {
                dgvAlquiler.Rows.Add(new object[] {
                    alq.Numero_Alquiler,
                    alq.Fecha_Entrega.ToString("dd/MM/yyyy"),
                    alq.Fecha_Devolucion.ToString("dd/MM/yyyy"),
                    alq.Direccion});
            }
        }

        private void dgvAlquiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlquiler.CurrentCell.ColumnIndex == 3)
            {
                int nro = int.Parse(dgvAlquiler.CurrentRow.Cells["colAlq"].Value.ToString());
                new FrmDetallesAlquiler(nro, fabrica).ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvAlquiler.CurrentRow.Cells["ColAlq"].Value.ToString());
            new FrmModificarAlquiler(nro, fabrica).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el alquiler seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvAlquiler.CurrentRow != null)
                {
                    int nro = int.Parse(dgvAlquiler.CurrentRow.Cells["colAlq"].Value.ToString());
                    if (servicio.EliminarAlquiler(nro))
                    {
                        MessageBox.Show("El alquiler se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("El alquiler NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
