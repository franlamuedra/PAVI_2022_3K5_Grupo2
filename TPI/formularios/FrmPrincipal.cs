using TPI.formularios;
using TPI.formularios.Herramientas;
using TPI.formularios.Proveedores;
using TPI.formularios.Transacciones;
using TPI.Reportes;
using TPI.Servicios;

namespace TPI
{
    public partial class FrmPrincipal : Form
    {
        private FabricaServicioMantenimiento fabrica;
        private FabricaServicioAlquiler fabricaA;
        public FrmPrincipal(FabricaServicioMantenimiento fabrica, FabricaServicioAlquiler fabricaA)
        {
            InitializeComponent();
            this.fabrica = fabrica;
            this.fabricaA = fabricaA;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            
            tsmUsuario.Text = login.DevolverUsuario();
        }       

        private void consultarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarMaterial().ShowDialog();
        }

        private void consultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarProveedor().ShowDialog();
        }

        private void consultarProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarHerramienta().ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Ferreteria Industrial V1.0", "PAVI2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarMantenimientos(fabrica).ShowDialog();
        }

        private void nuevoMantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoMantenimiento(fabrica).ShowDialog();
        }

        private void reporteDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReporteMantenimientos(fabrica).ShowDialog();
        }

        private void consultarAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarAlquileres(fabricaA).ShowDialog();
        }

        private void nuevoAlqulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoAlquiler(fabricaA).ShowDialog();
        }
    }
}