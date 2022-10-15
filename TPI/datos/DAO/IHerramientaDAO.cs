using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public interface IHerramientaDAO
    {
        List<Herramienta> GetByFilter(string nombre, bool activo);
        int Create(Herramienta her);
        bool ValidateProv(int cod);
    }
}
