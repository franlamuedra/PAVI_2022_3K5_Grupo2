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
using TPI.datos.DAO;
using TPI.dominio;

namespace TPI.formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD:TPI/formularios/FrmLogin.cs
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
=======
            if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUser.Text;
                string password = txtPassword.Text;
                bool resultado = false;
                try
                {
                    resultado = UsuariosDAO.ValidarUsuario(nombreDeUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password);
                        Principal ventana = new Principal(usu, this);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar usuario " + ex);
                }

>>>>>>> b6f97d272f579db03cfdf9ec4453fefc9f92980b:TPI/formularios/Login.cs
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

<<<<<<< HEAD:TPI/formularios/Login.cs
<<<<<<< HEAD:TPI/formularios/FrmLogin.cs
                String consultaSql = string.Concat(" SELECT * FROM Usuarios WHERE Usuario =  '", oUsuario, "'");           
=======
                String consultaSql = string.Concat(" SELECT * ", "   FROM Usuarios ", "  WHERE Usuario =  '", oUsuario, "'");
>>>>>>> b6f97d272f579db03cfdf9ec4453fefc9f92980b:TPI/formularios/Login.cs
=======
                String consultaSql = string.Concat(" SELECT * FROM t_Usuarios WHERE Usuario =  '", oUsuario, "'");           
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1:TPI/formularios/FrmLogin.cs
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

    }
}
