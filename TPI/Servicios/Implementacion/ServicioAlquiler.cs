using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.datos.DAO;
using TPI.dominio;
using TPI.Servicios.Interfaz;

namespace TPI.Servicios.Implementacion
{
    public class ServicioAlquiler : IServicioAlquiler
    {
        private IAlquilerDAO dao;

        public ServicioAlquiler()
        {
            dao = new AlquilerDAO();
        }

        public bool CrearAlquiler(Alquiler oAlquiler)
        {
            return dao.Create(oAlquiler);
        }

        public bool EliminarAlquiler(int nro)
        {
            return dao.Delete(nro);
        }

        public bool ModificarAlquiler(Alquiler oAlquiler)
        {
            return dao.Update(oAlquiler);
        }

        public List<Alquiler> ObtenerAlquileres(DateTime desde, DateTime hasta)
        {
            return dao.GetAlquilerByFilter(desde, hasta);
        }

        public Alquiler ObtenerAlquilerPorNro(int nro)
        {
            return dao.GetAlquilerPorNro(nro);
        }

        public List<Herramienta> ObtenerHerramientas()
        {
            return dao.GetHerramientas();
        }

        public DataTable ObtenerReporteAlquiler(string marca)
        {
            return dao.GetReport(marca);
        }

        public int ProximoAlquiler()
        {
            return dao.NextAlquiler();
        }
    }
}
