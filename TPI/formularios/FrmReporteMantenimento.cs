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
            //DataTable dt = servicio.ObtenerReporteHerramientas(cboModelo.SelectedValue.ToString());

            DataTable dt = HelperDB.GetInstance().ConsultaSQL(
                "SELECT t_Mantenimientos.Numero_Mantenimiento, t_Mantenimientos.Fecha, t_Detalles_Mantenimiento.Cambios, t_Herramientas.Cod_Herramienta, t_Herramientas.Marca_Herramienta " +
                "FROM t_Detalles_Mantenimiento " +
                "JOIN t_Mantenimientos ON t_Detalles_Mantenimiento.Numero_Mantenimiento = t_Mantenimientos.Numero_Mantenimiento " +
                "JOIN t_Herramientas ON t_Detalles_Mantenimiento.Codigo_Herramienta = t_Herramientas.Cod_Herramienta " +
                "WHERE t_Herramientas.Modelo_Herramienta = '" + cboModelo.SelectedValue.ToString() + "'");

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt));
            reportViewer2.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReporteMantenimientos_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }


    }
}
