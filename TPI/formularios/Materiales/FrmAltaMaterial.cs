using TPI.Servicios;
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
        private int accion; //1-2-3
        private Material oMaterial;
        // private Gestor gestor;
        public FrmAltaMaterial(int accion, Material oMaterial)
        {
            InitializeComponent();
            this.accion = accion;
            this.oMaterial = oMaterial;
            // gestor = new GestorProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe escribir el nombre del material", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboUnidadMedida.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe elegir la unidad de Medida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                return;
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
