using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Alquiler
    {
        public int Numero_Alquiler { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        public string Direccion { get; set; }
        public List<DetalleAlquiler> Detalle { get; set; }

        public Alquiler()
        {
            Detalle = new List<DetalleAlquiler>();
        }

        public void AgregarDetalle(DetalleAlquiler detalle)
        {
            Detalle.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
    }
}
