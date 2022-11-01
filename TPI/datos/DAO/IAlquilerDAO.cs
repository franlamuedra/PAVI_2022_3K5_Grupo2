using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public interface IAlquilerDAO
    {
        List<Herramienta> GetHerramientas();
        bool Create(Alquiler oAlquiler);
        bool Update(Alquiler oAlquiler);
        bool Delete(int nro);
        List<Alquiler> GetAlquilerByFilter(DateTime desde, DateTime hasta);
        int NextAlquiler();
        Alquiler GetAlquilerPorNro(int nro);
        DataTable GetReport(string modelo);
    }
}
