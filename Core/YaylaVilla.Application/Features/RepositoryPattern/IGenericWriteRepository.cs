using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites.Common;

namespace YaylaVilla.Application.Features.RepositoryPattern
{
    public interface IGenericWriteRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task SaveChangesAsync();
    }
}
