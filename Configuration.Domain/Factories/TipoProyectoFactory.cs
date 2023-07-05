using Configuration.Domain.Model.TipoProyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Factories
{
    public class TipoProyectoFactory : ITipoProyectoFactory
    {
        public TipoProyecto CrearTipoProyecto()
        {
            return new TipoProyecto();
        }

        public TipoProyecto CrearTipoProyecto(string nombre, string descripcion)
        {
            return new TipoProyecto(nombre, descripcion);
        }
    }
}
