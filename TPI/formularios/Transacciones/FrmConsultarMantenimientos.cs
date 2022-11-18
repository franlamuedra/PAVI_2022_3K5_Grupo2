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
using TPI.Servicios.Implementacion;
using TPI.Servicios.Interfaz;

namespace TPI.formularios.Transacciones
{
    public partial class FrmConsultarMantenimientos : Form
    {
        private IServicioMantenimiento servicio;
        private FabricaServicioMantenimiento fabrica;

        public FrmConsultarMantenimientos(FabricaServicioMantenimiento fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            servicio = fabrica.CrearServicioMantenimiento();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvMantenimiento.Rows.Clear();
            List<Mantenimiento> lst = servicio.ObtenerMantenimientos(dtpDesde.Value, dtpHasta.Value, txtEmpleado.Text);
            foreach (Mantenimiento mant in lst)
            {
                dgvMantenimiento.Rows.Add(new object[] {
                    mant.Numero_Mantenimiento,
                    mant.Fecha.ToString("dd/MM/yyyy"),
                    mant.Nombre_Empleado});
            }
        }

        private void dgvMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMantenimiento.CurrentCell.ColumnIndex == 3)
            {
                int nro = int.Parse(dgvMantenimiento.CurrentRow.Cells["colNum"].Value.ToString());
                new FrmDetallesMantenimiento(nro, fabrica).ShowDialog();
            }
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvMantenimiento.CurrentRow.Cells["ColNum"].Value.ToString());
            new FrmModificarMantenimiento(nro, fabrica).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el mantenimiento seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvMantenimiento.CurrentRow != null)
                {
                    int nro = int.Parse(dgvMantenimiento.CurrentRow.Cells["colNum"].Value.ToString());
                    if (servicio.EliminarMantenimiento(nro))
                    {
                        MessageBox.Show("El mantenimiento se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("El mantenimiento NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvMantenimiento_Click(object sender, EventArgs e)
        {
            DataGridViewRow actual = dgvMantenimiento.CurrentRow;
            if (actual != null)
            {
                btnBorrar.Enabled = btnEditar.Enabled = true;
            }
        }

        private void FrmConsultarMantenimientos_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(7);
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
