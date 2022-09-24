namespace TPI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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
            FrmConsultarMaterial frmMateriales = new FrmConsultarMaterial();
            frmMateriales.ShowDialog();
        }

        private void nuevoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FrmAltaMaterial frmAltaMaterial = new FrmAltaMaterial();
            // frmAltaMaterial.ShowDialog();
        }
    }
}