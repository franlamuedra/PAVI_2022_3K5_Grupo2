using TPI.formularios;
using TPI.formularios.Herramientas;
using TPI.formularios.Proveedores;

namespace TPI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
 
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

    }
}