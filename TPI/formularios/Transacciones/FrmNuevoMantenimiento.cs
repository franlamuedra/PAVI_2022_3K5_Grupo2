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
    public partial class FrmNuevoMantenimiento : Form
    {
        private IServicioMantenimiento servicio;
        private Mantenimiento nuevo;
        public FrmNuevoMantenimiento(FabricaServicioMantenimiento fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicioMantenimiento();

            CargarHerramientas();
            nuevo = new Mantenimiento();
        }

        private void CargarHerramientas()
        {
            cboHerramientas.DataSource = servicio.ObtenerHerramientas();
            cboHerramientas.DisplayMember = "Codigo";
            cboHerramientas.ValueMember = "Codigo";
        }

        private void FrmNuevoMantenimiento_Load(object sender, EventArgs e)
        {
            ProximoMantenimiento();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtCambios.Text = "";
            this.ActiveControl = cboHerramientas;
        }

        private void ProximoMantenimiento()
        {
            int next = servicio.ProximoMantenimiento();
            if (next > 0)
                lblMantenimiento.Text = "Mantenimiento N: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener num de mantenimiento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboHerramientas.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una herramienta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCambios.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar los cambios", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColHer"].Value.ToString().Equals(cboHerramientas.Text))
                {
                    MessageBox.Show("Herramienta: " + cboHerramientas.Text + " ya se encuentra como detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Herramienta h = (Herramienta)cboHerramientas.SelectedItem;
            string cambios = txtCambios.Text;

            DetalleMantenimiento detalle = new DetalleMantenimiento(h, cambios);
            nuevo.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] {h.Codigo, txtCambios.Text});
            
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 2)
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtEmpleado.Text == "")
            {
                MessageBox.Show("Debe ingresar un empleado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarMantenimiento();
        }

        private void GuardarMantenimiento()
        {
            nuevo.Fecha = Convert.ToDateTime(txtFecha.Text);
            nuevo.Nombre_Empleado = txtEmpleado.Text;

            if (servicio.CrearMantenimiento(nuevo))
            {
                MessageBox.Show("Mantenimiento registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
