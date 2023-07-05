using Configuration.Domain.Model.Requisito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Factories
{
    public class RequisitoFactory : IRequisitoFactory
    {
        public Requisito CrearRequisito()
        {
            return new Requisito();
        }

        public Requisito CrearRequisito(string nombre, string descripcion)
        {
            return new Requisito(nombre, descripcion);
        }
    }
}
