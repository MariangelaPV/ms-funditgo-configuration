using System.Threading.Tasks;

namespace Configuration.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
