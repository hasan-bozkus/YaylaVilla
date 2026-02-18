using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites.Common;

namespace YaylaVilla.Application.Features.RepositoryPattern
{
    public interface IGenericReadRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetListAllAsync();
        Task<T> GetByIDAsync(int id);
    }
}
