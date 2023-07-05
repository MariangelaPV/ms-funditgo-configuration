using System;
using Configuration.Domain.Model.Proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Factories
{
    public interface IProyectoFactory
    {
        Proyecto CrearProyecto(string nombre);

        Proyecto CrearProyecto();
    }
}
