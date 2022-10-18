using TPI.formularios;
using TPI.formularios.Herramientas;
using TPI.formularios.Proveedores;
using TPI.formularios.Transacciones;
using TPI.Servicios;

namespace TPI
{
    public partial class FrmPrincipal : Form
    {
        private FabricaServicioMantenimiento fabrica;
        public FrmPrincipal(FabricaServicioMantenimiento fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
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
    }
}