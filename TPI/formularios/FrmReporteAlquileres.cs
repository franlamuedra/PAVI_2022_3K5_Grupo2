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
using TPI.Servicios;
using TPI.Servicios.Interfaz;

namespace TPI.formularios
{
    public partial class FrmReporteAlquileres : Form
    {
        private IServicioAlquiler servicio;
        public FrmReporteAlquileres(FabricaServicioAlquiler fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicioAlquiler ();

            CargarHerramientas();
        }

        private void CargarHerramientas()
        {
            cboModelo.DataSource = servicio.ObtenerHerramientas();
            cboModelo.DisplayMember = "Modelo";
            cboModelo.ValueMember = "Modelo";


            cboMarca.DataSource = servicio.ObtenerHerramientas();
            cboMarca.DisplayMember = "Marca";
            cboMarca.ValueMember = "Marca";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable dt = HelperDB.GetInstance().ConsultaSQL("SELECT        t_Alquileres.Numero_Alquiler, t_Alquileres.Fecha_Entrega, t_Alquileres.Fecha_Devolucion, t_Alquileres.Direccion, t_Detalles_Alquiler.Codigo_Herramienta, t_Herramientas.Marca_Herramienta, " +
                         "t_Herramientas.Modelo_Herramienta " +
                         "FROM            t_Alquileres JOIN " +
                         "t_Detalles_Alquiler ON t_Alquileres.Numero_Alquiler = t_Detalles_Alquiler.Numero_Alquiler JOIN " +
                         "t_Herramientas ON t_Detalles_Alquiler.Codigo_Herramienta = t_Herramientas.Cod_Herramienta  WHERE t_Herramientas.Modelo_Herramienta = '" + cboModelo.SelectedValue.ToString() + "' AND t_Herramientas.Marca_Herramienta = '" + cboMarca.SelectedValue.ToString() + "'");

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
