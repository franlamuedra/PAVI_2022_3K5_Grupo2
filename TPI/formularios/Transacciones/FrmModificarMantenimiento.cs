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
    public partial class FrmModificarMantenimiento : Form
    {
        private Mantenimiento oMantenimiento;
        private IServicioMantenimiento servicio;
        public FrmModificarMantenimiento(int numMant, FabricaServicioMantenimiento fabrica)
        {
            InitializeComponent();
            oMantenimiento = new Mantenimiento();
            oMantenimiento.Numero_Mantenimiento = numMant;
            servicio = fabrica.CrearServicioMantenimiento();
            CargarHerramientas();
        }

        private void CargarHerramientas()
        {
            List<Herramienta> lst = servicio.ObtenerHerramientas();
            if (lst.Count > 0)
            {
                cboHerramientas.DataSource = lst;
                cboHerramientas.DisplayMember = "Codigo";
                cboHerramientas.ValueMember = "Codigo";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboHerramientas.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una herramienta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCambios.Text == "")
            {
                MessageBox.Show("Debe ingresar los cambios", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colHer"].Value.ToString().Equals(cboHerramientas.Text))
                {
                    MessageBox.Show("Herramienta: " + cboHerramientas.Text + " ya se encuentra como detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            Herramienta h = (Herramienta)cboHerramientas.SelectedItem;
            string cambios = txtCambios.Text;

            DetalleMantenimiento detalle = new DetalleMantenimiento(h, cambios);
            oMantenimiento.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { h.Codigo, txtCambios.Text });
        }

        private void FrmModificarMantenimiento_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + oMantenimiento.Numero_Mantenimiento.ToString();
            string sp = "SP_Consultar_Detalles_Mantenimiento";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@num_man", oMantenimiento.Numero_Mantenimiento));

            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);
            bool primero = true;

            foreach (DataRow fila in dt.Rows)
            {
                if (primero)
                {
                    oMantenimiento.Nombre_Empleado = fila["Nombre_Empleado"].ToString();
                    oMantenimiento.Fecha = DateTime.Parse(fila["fecha"].ToString());
                    txtEmpleado.Text = oMantenimiento.Nombre_Empleado;
                    primero = false;
                }
                int codHerramienta = int.Parse(fila["Codigo_Herramienta"].ToString());

                Herramienta oHerramienta = new Herramienta(codHerramienta);
                string cambio = fila["Cambios"].ToString();
                DetalleMantenimiento detalle = new DetalleMantenimiento(oHerramienta, cambio);
                oMantenimiento.AgregarDetalle(detalle);

                dgvDetalles.Rows.Add(new object[] {
                    oHerramienta.Codigo,
                    oHerramienta.Marca,
                    oHerramienta.Modelo,
                    detalle.Cambios
                });
            }

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
            oMantenimiento.Nombre_Empleado = txtEmpleado.Text;

            if (servicio.ModificarMantenimiento(oMantenimiento))
            {
                MessageBox.Show("Mantenimiento modificado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo modificar el mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 2)
            {
                oMantenimiento.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }
    }
}
