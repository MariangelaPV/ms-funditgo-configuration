using Configuration.Application.Dto.Requisitos;

namespace Configuration.Application.Dto.TipoProyectos
{
    public class RequisitoTipoDto
    {
        public Guid Id { get; set; }
        public RequisitoDto Requisito { get; set; }
        public TipoProyectoDto TipoProyecto { get; set; }
        public bool Obligatorio { get; set; }
        public int Orden { get; set; }
    }
}
