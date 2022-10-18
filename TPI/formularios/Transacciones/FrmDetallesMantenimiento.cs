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
    public partial class FrmDetallesMantenimiento : Form
    {
        private int numMant;
        private IServicioMantenimiento servicio;
        public FrmDetallesMantenimiento(int numMant, FabricaServicioMantenimiento fabrica)
        {
            InitializeComponent();
            this.numMant = numMant;
            servicio = fabrica.CrearServicioMantenimiento();
        }

        private void FrmDetallesMantenimiento_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + numMant.ToString();
            Mantenimiento oMantenimiento = servicio.ObtenerMantenimientoPorNro(numMant);
            
            txtEmpleado.Text = oMantenimiento.Nombre_Empleado;
            mtxtFecha.Text = oMantenimiento.Fecha.ToString("dd/MM/yyyy");

            foreach(DetalleMantenimiento detalle in oMantenimiento.Detalle)
            {
                dgvDetalles.Rows.Add(new object[] { detalle.Herramienta.Codigo, detalle.Cambios });
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
