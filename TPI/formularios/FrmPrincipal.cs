using TPI.formularios;

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

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clase sin implementar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clase sin implementar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void consultarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarMaterial().ShowDialog();
        }

        private void nuevoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaMaterial(1, new Material()).ShowDialog();          
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Ferreteria Industrial V1.0", "PAVI2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}