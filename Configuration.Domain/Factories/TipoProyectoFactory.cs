using Configuration.Domain.Model.TipoProyectos;

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
