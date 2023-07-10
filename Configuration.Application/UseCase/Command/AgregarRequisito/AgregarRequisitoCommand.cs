using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Application.UseCase.Command.AgregarRequisito
{
    public class AgregarRequisitoCommand : IRequest<Guid>
    {
        public Guid ProyectoId { get; set; }
        public Guid RequisitoId { get; set; }
        public string Valor { get; set; }
    }
}
