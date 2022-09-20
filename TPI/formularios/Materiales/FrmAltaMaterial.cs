using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.dominio;

namespace TPI
{
    public partial class FrmAltaMaterial : Form
    {
        public FrmAltaMaterial()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe escribir el nombre del material", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                int cod = (int)nudCodMaterial.Value;
                string nom = txtNombre.Text;
                double cant = (double)nudCantidad.Value;
                string uni = "s";
                DateTime fecIng = DateTime.Now;
                Proveedor prov = new Proveedor();
                Material material = new Material(cod, nom, cant, uni, fecIng, prov);
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
