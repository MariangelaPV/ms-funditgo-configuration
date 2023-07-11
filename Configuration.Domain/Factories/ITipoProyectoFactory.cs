using Configuration.Domain.Model.TipoProyectos;

namespace Configuration.Domain.Factories
{
    public interface ITipoProyectoFactory
    {
        TipoProyecto CrearTipoProyecto(string nombre, string descripcion);

        TipoProyecto CrearTipoProyecto();
    }
}
