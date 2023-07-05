using Configuration.Domain.Model.Requisito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Factories
{
    public interface IRequisitoFactory
    {
        Requisito CrearRequisito(string nombre, string descripcion);

        Requisito CrearRequisito();
    }
}
