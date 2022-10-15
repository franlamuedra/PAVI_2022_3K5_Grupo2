using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.datos.DAO;
using TPI.dominio;

namespace TPI.Servicios
{
    internal class GestorHerramientas
    {
        private IHerramientaDAO dao;

        public GestorHerramientas()
        {
            dao = new HerramientaDAO();
        }

        public List<Herramienta> ConsultarHerramientaFiltro(String marca, bool activo)
        {
            List<Herramienta> lista = dao.GetByFilter(marca, activo);
            return lista;
        }

        public int CrearHerramienta(Herramienta oHerramienta)
        {
            return dao.Create(oHerramienta);
        }

        public bool ValidarProveedor(int cod)
        {
            return dao.ValidateProv(cod);
        }
    }
}
