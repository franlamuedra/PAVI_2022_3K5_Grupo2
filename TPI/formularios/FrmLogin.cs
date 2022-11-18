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
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario y contrasena", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
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

                String consultaSql = string.Concat(" SELECT * FROM t_Usuarios WHERE Usuario =  '", oUsuario, "'");           
                DataTable res = HelperDB.GetInstance().ConsultaSQL(consultaSql);

                if (res.Rows.Count >= 1)
                {                 
                    if (res.Rows[0]["Password"].ToString() == oPassword)
                    {
                        usuarioValido = true;
                    }

                    else 
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public string DevolverUsuario()
        {
            return txtUsuario.Text;
        }

    }
}
