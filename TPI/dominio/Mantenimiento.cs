using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Mantenimiento
    {
        public int Numero_Mantenimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre_Empleado { get; set; }

        public List<DetalleMantenimiento> Detalle { get; set; }

        public Mantenimiento()
        {
            Detalle = new List<DetalleMantenimiento>();
        }

        public void AgregarDetalle(DetalleMantenimiento detalle)
        {
            Detalle.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
    }
}
