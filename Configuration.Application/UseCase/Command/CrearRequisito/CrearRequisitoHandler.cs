using Configuration.Domain.Factories;
using Configuration.Domain.Repositories;
using MediatR;
using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Application.UseCase.Command.CrearRequisito
{
    public class CrearRequisitoHandler : IRequestHandler<CrearRequisitoCommand, Guid>
    {
        private readonly IRequisitoRepository _requisitoRepository;
        private readonly IRequisitoFactory _requisitoFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearRequisitoHandler(IRequisitoRepository requisitoRepository, IRequisitoFactory requisitoFactory, )

    }
}
