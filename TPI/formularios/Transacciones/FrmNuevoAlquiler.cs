using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.datos;
using TPI.dominio;
using TPI.Servicios;
using TPI.Servicios.Interfaz;

namespace TPI.formularios.Transacciones
{
    public partial class FrmNuevoAlquiler : Form
    {
        private IServicioAlquiler servicio;
        private Alquiler nuevo;

        public FrmNuevoAlquiler(FabricaServicioAlquiler fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicioAlquiler();

            CargarHerramientas();
            nuevo = new Alquiler();
        }

        private void FrmNuevoAlquiler_Load(object sender, EventArgs e)
        {
            ProximoAlquiler();
            dtpEnt.Value = DateTime.Now;
            dtpDev.Value = DateTime.Now;
            this.ActiveControl = cboCodigo;
        }

        private void CargarHerramientas()
        {
            cboCodigo.DataSource = servicio.ObtenerHerramientas();
            cboCodigo.DisplayMember = "Codigo";
            cboCodigo.ValueMember = "Codigo";
        }

        private void ProximoAlquiler()
        {
            int next = servicio.ProximoAlquiler();
            if (next > 0)
                label1.Text = "Mantenimiento N: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener num de mantenimiento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una herramienta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboCodigo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar los cambios", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["ColHer"].Value.ToString().Equals(cboCodigo.Text))
                {
                    MessageBox.Show("Herramienta: " + cboCodigo.Text + " ya se encuentra como detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Herramienta h = (Herramienta)cboCodigo.SelectedItem;

            DetalleAlquiler detalle = new DetalleAlquiler(h);
            nuevo.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(new object[] { h.Codigo});
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 2)
            {
                nuevo.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar una direccion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarAlquiler();
        }

        private void GuardarAlquiler()
        {
            nuevo.Direccion = textBox1.Text;

            if (servicio.CrearAlquiler(nuevo))
            {
                MessageBox.Show("Alquiler registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el alquiler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedValue != null)
            {
                string id = cboCodigo.SelectedValue.ToString();
                Herramienta herramienta = HelperDB.GetInstance().ObtenerHerramientaPorId(id);
                txtModelo.Text = herramienta.Modelo;
                txtMarca.Text = herramienta.Marca;
            }
        }
    }
}
