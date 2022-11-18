using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.datos.DAO;
using TPI.dominio;

namespace TPI.Servicios
{
    public class GestorPresupuestos
    {
        private IMantenimientoDAO dao;

        public GestorPresupuestos()
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

        public List<Mantenimiento> ObtenerMantenimientos(string fecha, string empl)
        {
            return dao.GetMantenimientoByFilter(fecha, empl);
        }
    }
}
