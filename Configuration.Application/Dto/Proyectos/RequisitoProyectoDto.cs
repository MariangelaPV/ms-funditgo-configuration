using Configuration.Application.Dto.Requisitos;

namespace Configuration.Application.Dto.Proyectos
{
    public class RequisitoProyectoDto
    {
        public Guid Id { get; set; }
        public ProyectoDto Proyecto { get; set; }
        public RequisitoDto Requisito { get; set; }
        public string Valor { get; set; }
    }
}
