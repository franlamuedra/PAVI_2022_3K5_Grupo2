using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.datos;

namespace TPI.formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                // Mostramos un mensaje afirmativo en caso de que el usuario sea valido.
                MessageBox.Show("Usted a ingresado al sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public bool ValidarCredenciales(string oUsuario, string oPassword)
        {         
            bool usuarioValido = false;
            
            try
            {

                String consultaSql = string.Concat(" SELECT * ", "   FROM Usuarios ", "  WHERE Usuario =  '", oUsuario, "'");           
                DataTable res = HelperDB.GetInstance().ConsultaSQL(consultaSql);

                if (res.Rows.Count >= 1)
                {                 
                    if (res.Rows[0]["Password"].ToString() == oPassword)
                    {
                        usuarioValido = true;
                    }
                }

            }

            catch (SqlException ex)
            {               
                MessageBox.Show(string.Concat("Error en base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioValido;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

    }
}
