using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Proveedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
<<<<<<< HEAD
        public string Apellido { get; set; }
        public int Telefono { get; set; }
=======
        public string Telefono { get; set; }
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public Proveedor(int codigo, string nom, string ap, int tel, string mail, string direccion)
        {
<<<<<<< HEAD
            Codigo = codigo;
            Nombre = nom;
            Apellido = ap;
            Telefono = tel;
            Mail = mail;
            Direccion = direccion;
        }
=======

        }

>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
    }
}
