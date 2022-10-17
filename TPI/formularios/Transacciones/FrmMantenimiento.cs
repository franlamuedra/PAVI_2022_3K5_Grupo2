using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.datos.DAO;
using TPI.dominio;

namespace TPI.formularios.Transacciones
{
<<<<<<< HEAD:TPI/formularios/Empleados/FrmEmpleados.cs
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtId.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }
        private void CargarGrilla()
        {
            try
            {
                grdEmpleados.DataSource = EmpleadosDAO.ObtenerListadoPersonasReducido();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener empleados");
            }

        }

        private Empleado ObtenerDatosPersona()
        {
            Empleado p = new Empleado();
            p.Nombre = txtName.Text.Trim();
            p.Apellido = txtSurname.Text.Trim();
            p.Telefono = int.Parse(txtPhoneNumber.Text.Trim());
            p.Documento = int.Parse(txtId.Text.Trim());
            p.Direccion = txtAddress.Text;
           
            return p;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Empleado p = ObtenerDatosPersona();
            bool resultado = EmpleadosDAO.AgregarEmpleado(p);
            if (resultado)
            {
                MessageBox.Show("Empleado agregado con éxito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar el empleado");
            }
        }

        private void grdEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdEmpleados.Rows[index];
            MessageBox.Show(filaSeleccionada.Cells["Documento"].Value.ToString());
            int indice = e.RowIndex;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            int documento = (int)filaSeleccionada.Cells["Documento"].Value;
            Empleado p = EmpleadosDAO.ObtenerEmpleado(documento);
            LimpiarCampos();
            CargarCampos(p);
        }
        private void CargarCampos(Empleado e)
        {
            txtName.Text = e.Nombre;
            txtSurname.Text = e.Apellido;
            txtId.Text = e.Documento.ToString();
            txtAddress.Text = e.Direccion;
            txtPhoneNumber.Text = e.Telefono.ToString();
            
        }

=======
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1:TPI/formularios/Transacciones/FrmMantenimiento.cs
    }
}
