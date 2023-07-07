using Configuration.Domain.Model.TipoProyecto;
using SharedKernel.Core;
using System;
using System.Threading.Tasks;

namespace Configuration.Domain.Repositories
{
    public interface ITipoProyectoRepository : IRepository<TipoProyecto, Guid>
    {
        Task UpdateAsync(TipoProyecto obj);
        Task RemoveAsync(TipoProyecto obj);
    }
}
