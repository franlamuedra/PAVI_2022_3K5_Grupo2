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
    public partial class FrmDetallesAlquiler : Form
    {
        private int numAlq;
        private IServicioAlquiler servicio;
        public FrmDetallesAlquiler(int numAlq, FabricaServicioAlquiler fabrica)
        {
            InitializeComponent();
            this.numAlq = numAlq;
            servicio = fabrica.CrearServicioAlquiler();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetallesAlquiler_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + numAlq.ToString();
            Alquiler oAlquiler = servicio.ObtenerAlquilerPorNro(numAlq);

            maskedTextBox1.Text = oAlquiler.Fecha_Entrega.ToString("dd/MM/yyyy");
            maskedTextBox2.Text = oAlquiler.Fecha_Devolucion.ToString("dd/MM/yyyy");

            foreach (DetalleAlquiler detalle in oAlquiler.Detalle)
            {
                dgvDetalle.Rows.Add(new object[] { detalle.Herramienta.Codigo});
            }
        }
    }
}
