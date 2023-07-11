using Configuration.Domain.Model.Proyectos;

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
