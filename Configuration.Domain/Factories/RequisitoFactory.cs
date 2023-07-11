using Configuration.Domain.Model.Requisitos;

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
