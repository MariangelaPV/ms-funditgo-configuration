using Configuration.Domain.Model.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Factories
{
    public class ProyectoFactory : IProyectoFactory
    {
        public Proyecto CrearProyecto()
        {
            return new Proyecto();
        }

        public Proyecto CrearProyecto(string nombre)
        {
            return new Proyecto(nombre);
        }
    }
}
