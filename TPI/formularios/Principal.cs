<<<<<<< HEAD:TPI/formularios/Principal.cs
using Microsoft.VisualBasic.Logging;
using TPI.dominio;
using TPI.formularios;

namespace TPI
{
    public partial class Principal : Form
    {
        Login login;
        Usuario usu;

        public Principal(Usuario usu, Login log)
        {
            InitializeComponent();
            this.login = log;
            this.usu = usu;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Login login = new Login();
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
=======
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
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1:TPI/formularios/FrmPrincipal.cs
}