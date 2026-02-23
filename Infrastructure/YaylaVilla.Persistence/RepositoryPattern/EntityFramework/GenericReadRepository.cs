using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern;
using YaylaVilla.Domain.Entites.Common;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework
{
    public class GenericReadRepository<T> : IGenericReadRepository<T> where T : BaseEntity
    {
        private readonly YaylaVillaContext _context;

        public GenericReadRepository(YaylaVillaContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
