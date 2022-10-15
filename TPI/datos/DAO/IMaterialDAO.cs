using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.datos.DAO
{
    public interface IMaterialDAO
    {
        List<Material> GetByFilter(string nombre, bool activo);
        int Create(Material mat);
        bool ValidateProv(int cod);     
    }
}
