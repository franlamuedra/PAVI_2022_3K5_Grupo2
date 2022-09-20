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
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.ShowDialog();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHerramientas frmHerramientas = new FrmHerramientas();
            frmHerramientas.ShowDialog();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarMaterial frmMateriales = new FrmConsultarMaterial();  
            frmMateriales.ShowDialog();
        }
    }
}