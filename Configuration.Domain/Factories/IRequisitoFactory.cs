using Configuration.Domain.Model.Requisitos;

namespace Configuration.Domain.Factories
{
    public interface IRequisitoFactory
    {
        Requisito CrearRequisito(string nombre, string descripcion);

        Requisito CrearRequisito();
    }
}
