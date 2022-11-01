using TPI.datos;
using TPI.dominio;
using TPI.Servicios;
using TPI.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPI.Reportes
{
    public partial class FrmReporteMantenimientos : Form
    {
        private IServicioMantenimiento servicio;
        public FrmReporteMantenimientos(FabricaServicioMantenimiento fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicioMantenimiento();

            CargarHerramientas();
        }

        private void CargarHerramientas()
        {
            cboModelo.DataSource = servicio.ObtenerHerramientas();
            cboModelo.DisplayMember = "Modelo";
            cboModelo.ValueMember = "Modelo";
        }

       private void btnGenerar_Click(object sender, EventArgs e)
       {
            DataTable dt = servicio.ObtenerReporteHerramientas(cboModelo.SelectedValue.ToString());
            rvReporte.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            rvReporte.RefreshReport();
       }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
