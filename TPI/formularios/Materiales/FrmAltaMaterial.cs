using TPI.Servicios;
using TPI.dominio;
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
using TPI.datos;

namespace TPI
{
    public partial class FrmAltaMaterial : Form
    {
        private int accion; //1-2-3
        private Material oMaterial;
        private GestorMateriales gestor;

        public FrmAltaMaterial(int accion, Material oMaterial)
        {
            InitializeComponent();
            this.accion = accion;
            this.oMaterial = oMaterial;
            // gestor = new GestorProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*if(nudCodMaterial.Value.Equals())
            {
                
            }*/

            if (cboUnidadMedida.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe elegir la unidad de Medida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboProveedor.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar el proveedor", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                return;
            }

            if (accion == 1)
            {
                int res = gestor.CrearMaterial(oMaterial);

                if (res == 1)
                {
                    MessageBox.Show("Material agregado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else if (accion == 2)
            {

                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@codigo", oMaterial.Codigo));
                lista.Add(new Parametro("@cantidad", oMaterial.Cantidad));
                lista.Add(new Parametro("@unidad", oMaterial.UnidadMedida));
                lista.Add(new Parametro("@fecha", oMaterial.FechaIngreso));
                lista.Add(new Parametro("@proveedor", oMaterial.ProveedorMa));

                string update = "UPDATE Materiales SET Codigo_Material = @codigo, Cantidad = @cantidad, Unidad_Medidad = @unidad, Cod_Proveedor = @proveedor, Fecha_Ingreso = @fecha";

                // int res = new HelperDB().EjecutarSQL(update, lista);
                int res = 1;

                if (res == 1)
                {
                    MessageBox.Show("Material modificado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ocurrio un error al modificar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@cod", oMaterial.Codigo));

                // no se puede hacer baja logica pq no tenemos atributo ACTIVO

                /* int res = new HelperDB().EjecutarSQL(delete, lista);
                if (res == 1)
                {
                    MessageBox.Show("Producto eliminado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } */
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaMaterial_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboProveedor, HelperDB.GetInstance().ConsultaSQL("Select * from Proveedores"), "Nombre", "Cod_Proveedor");
            if (accion != 1)
            {
                nudCodMaterial.Value = oMaterial.Codigo;
                nudCantidad.Value = (decimal)oMaterial.Cantidad;
                cboUnidadMedida.Text = oMaterial.UnidadMedida;
                // txtProveedor.Text = oMaterial.ProveedorMa;
                dtmFechaIngreso.Value = oMaterial.FechaIngreso;
                

                if (accion == 2)
                {
                    this.Text = "Modificar Material";
                }

                else
                {
                    grbMaterial.Enabled = false;
                    this.Text = "Registrar baja de Material";
                }

            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }
        
    }
}
