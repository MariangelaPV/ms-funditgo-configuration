using Configuration.Domain.Model.Proyecto;
using SharedKernel.Core;
using System;
using System.Threading.Tasks;

namespace Configuration.Domain.Repositories
{
    public interface IProyectoRepository : IRepository<Proyecto, Guid>
    {
        Task UpdateAsync(Proyecto obj);
        Task RemoveAsync(Proyecto obj);
    }
}
