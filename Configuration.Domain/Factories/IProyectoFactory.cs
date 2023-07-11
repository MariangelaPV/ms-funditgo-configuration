using Configuration.Domain.Model.Proyectos;

namespace Configuration.Domain.Factories
{
    public interface IProyectoFactory
    {
        Proyecto CrearProyecto(string nombre);

        Proyecto CrearProyecto();
    }
}
