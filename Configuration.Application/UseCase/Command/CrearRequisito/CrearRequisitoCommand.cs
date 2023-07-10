using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Application.UseCase.Command.CrearRequisito
{
    public record CrearRequisitoCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
