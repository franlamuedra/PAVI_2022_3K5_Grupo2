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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


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
            reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt));
            reportViewer2.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Ferreteria_Industrial;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Numero_Mantenimiento,Fecha,Nombre_Empleado From t_Mantenimientos");
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt));
            reportViewer2.RefreshReport();*/
        }

        /*private void FrmReporteMantenimientos_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "TPI.Reporte.rptHerramientas.rdlc";
            reportViewer2.Refresh();
        }*/
    }
}
