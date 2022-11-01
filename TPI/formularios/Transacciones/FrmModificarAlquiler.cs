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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPI.formularios.Transacciones
{
    public partial class FrmModificarAlquiler : Form
    {
        private Alquiler oAlquiler;
        private IServicioAlquiler servicio;
        public FrmModificarAlquiler(int numAlq, FabricaServicioAlquiler fabrica)
        {
            InitializeComponent();
            oAlquiler = new Alquiler();
            oAlquiler.Numero_Alquiler = numAlq;
            servicio = fabrica.CrearServicioAlquiler();
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

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar los cambios", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["colHer"].Value.ToString().Equals(cboHerramientas.Text))
                {
                    MessageBox.Show("Herramienta: " + cboHerramientas.Text + " ya se encuentra como detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            Herramienta h = (Herramienta)cboHerramientas.SelectedItem;
            string direccion = txtDireccion.Text;

            DetalleAlquiler detalle = new DetalleAlquiler(h);
            oAlquiler.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(new object[] { h.Codigo});
        }

        private void FrmModificarAlquiler_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + oAlquiler.Numero_Alquiler.ToString();
            string sp = "SP_Consultar_Detalles_Alquiler";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@num_alq", oAlquiler.Numero_Alquiler));

            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);
            bool primero = true;

            foreach (DataRow fila in dt.Rows)
            {
                if (primero)
                {
                    oAlquiler.Direccion = fila["Direccion"].ToString();
                    oAlquiler.Fecha_Entrega = DateTime.Parse(fila["Fecha_Entrega"].ToString());
                    oAlquiler.Fecha_Devolucion = DateTime.Parse(fila["Fecha_Devolucion"].ToString());
                    primero = false;
                }
                int codHerramienta = int.Parse(fila["Codigo_Herramienta"].ToString());

                Herramienta oHerramienta = new Herramienta(codHerramienta);
                DetalleAlquiler detalle = new DetalleAlquiler(oHerramienta);
                oAlquiler.AgregarDetalle(detalle);
                dgvDetalle.Rows.Add(new object[] {
                    oHerramienta.Codigo,
                    oHerramienta.Marca,
                    oHerramienta.Modelo,
                });
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
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
            oAlquiler.Direccion = txtDireccion.Text;

            if (servicio.ModificarAlquiler(oAlquiler))
            {
                MessageBox.Show("Alquiler modificado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo modificar el alquiler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 2)
            {
                oAlquiler.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }
    }
}
