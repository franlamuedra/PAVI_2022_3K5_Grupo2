using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Herramienta
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Codigo { get; set; }
        public int Codigo_Proveedor { get; set; }
        public int Vida_Util { get; set; }
        public bool Activo { get; set; }
        
        public Herramienta()
        {

        }

        public Herramienta(int codigo, string marca, string modelo)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Activo = true;
        }
        
        public Herramienta(int codigo)
        {
            Codigo = codigo;
            Activo = true;
        }



        public Herramienta(int codigo, string marca, string modelo, int vida, int codPro, bool activo)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Vida_Util = vida;
            Codigo_Proveedor = codPro;
            Activo = activo;
        }
    }



}
