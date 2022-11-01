using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Mantenimiento oMantenimiento = servicio.ObtenerMantenimientoPorNro(numMant);
            Font font = new Font("Arial", 14);
            int ancho = 300;
            int y = 20;

            e.Graphics.DrawString("---- Mantenimiento -----", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha: "+ mtxtFecha.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Empleado: " + txtEmpleado.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            foreach (DetalleMantenimiento detalle in oMantenimiento.Detalle)
            {
                e.Graphics.DrawString("Herramienta: " + detalle.Herramienta.Codigo, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                e.Graphics.DrawString("Cambios: " + detalle.Cambios, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }
            
        }
    }
}
