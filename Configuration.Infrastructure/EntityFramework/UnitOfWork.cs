using Configuration.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Infrastructure.EntityFramework
{
    internal class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(WriteDbContext)
        {
            _
        }

        public async Task Commit()
        {
            var domainEvents = 
            throw new NotImplementedException();
        }
    }
}
