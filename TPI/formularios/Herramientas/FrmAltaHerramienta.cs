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

namespace TPI.formularios.Herramientas
{
    public partial class FrmAltaHerramienta : Form
    {
        private int accion;
        private Herramienta oHerramienta;
        private GestorHerramientas gestor;

        public FrmAltaHerramienta(int accion, Herramienta oHerramienta)
        {
            InitializeComponent();
            this.accion = accion;
            this.oHerramienta = oHerramienta;
            gestor = new GestorHerramientas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar la marca de la herramienta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtModelo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar el modelo de la herramienta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!gestor.ValidarProveedor((int)nudProveedor.Value))
            {
                MessageBox.Show("Debe ingresar un proveedor válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            oHerramienta.Marca = txtMarca.Text;
            oHerramienta.Modelo = txtModelo.Text;
            oHerramienta.Vida_Util = (int)nudVida.Value;
            oHerramienta.Codigo_Proveedor = (int)nudProveedor.Value;
            oHerramienta.Activo = true;

            if (accion == 1)
            {
                int res = gestor.CrearHerramienta(oHerramienta);

                if (res == 1)
                {
                    MessageBox.Show("Herramienta agregada", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar la herramienta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (accion == 2)
            {

                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@codigo", oHerramienta.Codigo));
                lista.Add(new Parametro("@marca", oHerramienta.Marca));
                lista.Add(new Parametro("@modelo", oHerramienta.Modelo));
                lista.Add(new Parametro("@vida", oHerramienta.Vida_Util));            
                lista.Add(new Parametro("@proveedor", oHerramienta.Codigo_Proveedor));

                string update = "UPDATE t_Herramientas SET Cod_Proveedor = @proveedor, Marca_Herramienta = @marca, Modelo_Herramienta = @modelo, Vida_Util = @vida WHERE Cod_Herramienta = @codigo";

                int res = new HelperDB().EjecutarSQL(update, lista);

                if (res == 1)
                {
                    MessageBox.Show("Herramienta modificada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ocurrió un error al modificar la herramienta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@cod", oHerramienta.Codigo));

                string delete = "UPDATE t_Herramientas SET activo = 'N' WHERE Cod_Herramienta = @cod";

                int res = new HelperDB().EjecutarSQL(delete, lst);
                if (res == 1)
                {
                    MessageBox.Show("Herramienta eliminada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar la herramienta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaHerramienta_Load(object sender, EventArgs e)
        {
            if (accion != 1)
            {
                txtMarca.Text = oHerramienta.Marca;
                txtModelo.Text = oHerramienta.Modelo;
                nudProveedor.Value = oHerramienta.Codigo_Proveedor;
                nudVida.Value = oHerramienta.Vida_Util;

                if (accion == 2)
                {
                    this.Text = "Modificar Herramienta";
                }

                else
                {
                    grbHerramienta.Enabled = false;
                    this.Text = "Registrar baja de Herramienta";
                }
            }
        }
    }
}
