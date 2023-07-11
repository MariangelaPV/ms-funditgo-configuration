using Configuration.Domain.Model.Proyectos;
using Configuration.Domain.Repositories;
using Configuration.Infrastructure.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Infrastructure.EntityFramework.Repository.Proyectos
{
    internal class ProyectoRepository : IProyectoRepository
    {
        private readonly WriteDbContext _context;

        public ProyectoRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Proyecto obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Proyecto?> FindByIdAsync(Guid id)
        {
            return await _context.Proyecto
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task RemoveAsync(Proyecto obj)
        {
            _context.Proyecto.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Proyecto obj)
        {
            _context.Proyecto.Update(obj);
            return Task.CompletedTask;
        }
    }
}
