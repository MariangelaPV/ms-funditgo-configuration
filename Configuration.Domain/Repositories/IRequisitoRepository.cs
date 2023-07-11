using Configuration.Domain.Model.Requisitos;
using SharedKernel.Core;
using System;
using System.Threading.Tasks;

namespace Configuration.Domain.Repositories
{
    public interface IRequisitoRepository : IRepository<Requisito, Guid>
    {
        Task UpdateAsync(Requisito obj);
        Task RemoveAsync(Requisito obj);
    }
}
