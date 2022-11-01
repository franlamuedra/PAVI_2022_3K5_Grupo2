using Microsoft.Reporting.WinForms;
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
using TPI.Servicios.Interfaz;

namespace TPI.Reportes
{
    public partial class FrmReporteMantenimento : Form
    {
        private IServicioMantenimiento servicio;
        public FrmReporteMantenimento()
        {
            InitializeComponent();
        }

        private void FrmReporteMantenimento_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            
        }

        private void rptMantenimentos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HelperDB.GetInstance().ObtenerMantenimientos();

            ReportDataSource ds = new ReportDataSource("DSListado", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

        }

        private void CargarModelosHerramientas()
        {
            List<Herramienta> lst = servicio.ObtenerHerramientas();
            if (lst.Count > 0)
            {
                cboModelo.DataSource = lst;
                cboModelo.DisplayMember = "Modelo";
                cboModelo.ValueMember = "Modelo";
            }
        }

    }
}
