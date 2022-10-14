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
using TPI.datos;
using TPI.formularios;

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
            gestor = new GestorMateriales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe escribir el nombre del material", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboUnidadMedida.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe elegir la unidad de Medida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (nudProveedor.Value.Equals(String.Empty))
            {
                MessageBox.Show("Debe elegir la unidad de Medida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            oMaterial.Nombre = txtNombre.Text;
            oMaterial.Cantidad = (float)nudCantidad.Value;
            oMaterial.UnidadMedida = cboUnidadMedida.Text;
            oMaterial.ProveedorMa = (int)nudProveedor.Value;
            oMaterial.FechaIngreso = mtxtFechaIngreso.Text;
            oMaterial.Activo = true;

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
                lista.Add(new Parametro("@nombre", oMaterial.Nombre));
                lista.Add(new Parametro("@codigo", oMaterial.Codigo));
                lista.Add(new Parametro("@cantidad", oMaterial.Cantidad));
                lista.Add(new Parametro("@unidad", oMaterial.UnidadMedida));
                lista.Add(new Parametro("@fecha", oMaterial.FechaIngreso));
                lista.Add(new Parametro("@proveedor", oMaterial.ProveedorMa));

                string update = "UPDATE t_Materiales SET Nombre = @nombre, Cantidad = @cantidad, Unidad_Medida = @unidad, Cod_Proveedor = @proveedor, Fecha_Ingreso = @fecha WHERE Codigo_Material = @codigo";

                int res = new HelperDB().EjecutarSQL(update, lista);

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
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@cod", oMaterial.Codigo));

                string delete = "UPDATE t_Materiales SET activo = 'N' WHERE Codigo_Material = @cod";

                int res = new HelperDB().EjecutarSQL(delete, lst);
                if (res == 1)
                {
                    MessageBox.Show("Producto eliminado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaMaterial_Load(object sender, EventArgs e)
        {        
            if (accion != 1)
            {
                txtNombre.Text = oMaterial.Nombre;
                nudCantidad.Value = (decimal)oMaterial.Cantidad;
                cboUnidadMedida.Text = oMaterial.UnidadMedida;
                nudProveedor.Value = oMaterial.ProveedorMa;
                mtxtFechaIngreso.Text = oMaterial.FechaIngreso;
                
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

    }
}
