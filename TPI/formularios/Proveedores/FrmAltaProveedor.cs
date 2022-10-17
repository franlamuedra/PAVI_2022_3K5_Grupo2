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
using TPI.dominio;
using TPI.Servicios;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace TPI.formularios.Proveedores
{
    public partial class FrmAltaProveedor : Form
    {
        private int accion;
        private Proveedor oProveedor;
        private GestorProveedores gestor;

        public FrmAltaProveedor(int accion, Proveedor oProveedor)
        {
            InitializeComponent();
            this.accion = accion;
            this.oProveedor = oProveedor;
            gestor = new GestorProveedores();
        }

        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe escribir el nombre del proveedor", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (!validarEmail(txtMail.Text))
            {
                MessageBox.Show("Debe escribir el mail del proveedor correctamente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            if (txtDireccion.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe escribir la dirección del proveedor", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            oProveedor.Nombre = txtNombre.Text;
            oProveedor.Telefono = mtxtTelefono.Text;
            oProveedor.Mail = txtMail.Text;
            oProveedor.Direccion = txtDireccion.Text;
            oProveedor.Activo = true;

            if (accion == 1)
            {
                int res = gestor.CrearProveedor(oProveedor);

                if (res == 1)
                {
                    MessageBox.Show("Proveedor agregado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else if (accion == 2)
            {

                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@Nombre", oProveedor.Nombre));
                lista.Add(new Parametro("@Cod", oProveedor.Codigo));
                lista.Add(new Parametro("@Telefono", oProveedor.Telefono));
                lista.Add(new Parametro("@Mail", oProveedor.Mail));
                lista.Add(new Parametro("@Direccion", oProveedor.Direccion));

                string update = "UPDATE t_Proveedores SET Nombre = @Nombre, Telefono = @Telefono, Mail = @Mail, Direccion = @Direccion WHERE Cod_Proveedor = @Cod";

                int res = new HelperDB().EjecutarSQL(update, lista);

                if (res == 1)
                {
                    MessageBox.Show("Proveedor modificado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ocurrio un error al modificar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@cod", oProveedor.Codigo));

                string delete = "UPDATE t_Proveedores SET activo = 'N' WHERE Cod_Proveedor = @cod";

                int res = new HelperDB().EjecutarSQL(delete, lst);
                if (res == 1)
                {
                    MessageBox.Show("Proveedor eliminado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaProveedor_Load(object sender, EventArgs e)
        {
            if (accion != 1)
            {
                txtNombre.Text = oProveedor.Nombre;
                txtMail.Text = oProveedor.Mail;
                txtDireccion.Text = oProveedor.Direccion;
                mtxtTelefono.Text = oProveedor.Telefono;

                if (accion == 2)
                {
                    this.Text = "Modificar Proveedor";
                }

                else
                {
                    grbProveedor.Enabled = false;
                    this.Text = "Registrar baja de Proveedor";
                }
            }

        }
    }
}
