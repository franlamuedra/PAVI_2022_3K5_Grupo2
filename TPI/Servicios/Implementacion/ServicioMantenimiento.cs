using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.datos.DAO;
using TPI.dominio;
using TPI.Servicios.Interfaz;

namespace TPI.Servicios.Implementacion
{
    public class ServicioMantenimiento : IServicioMantenimiento
    {
        private IMantenimientoDAO dao;

        public ServicioMantenimiento()
        {
            dao = new MantenimientoDAO();
        }

        public bool CrearMantenimiento(Mantenimiento oMantenimiento)
        {
            return dao.Create(oMantenimiento);
        }

        public bool ModificarMantenimiento(Mantenimiento oMantenimiento)
        {
            return dao.Update(oMantenimiento);
        }

        public bool EliminarMantenimiento(int nro)
        {
            return dao.Delete(nro);
        }

        public List<Herramienta> ObtenerHerramientas()
        {
            return dao.GetHerramientas();
        }

        public List<Mantenimiento> ObtenerMantenimientos(DateTime desde, DateTime hasta, string empl)
        {
            return dao.GetMantenimientoByFilter(desde, hasta, empl);
        }

        public int ProximoMantenimiento()
        {
            return dao.NextMantenimiento();
        }

        public Mantenimiento ObtenerMantenimientoPorNro(int nro) 
        {
            return dao.GetMantenimientoPorNro(nro);
        }

        public DataTable ObtenerReporteHerramientas(string modelo)
        {
            return dao.GetReport(modelo);
        }
    }
}
