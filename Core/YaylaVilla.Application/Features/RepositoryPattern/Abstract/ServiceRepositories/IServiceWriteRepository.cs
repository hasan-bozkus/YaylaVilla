using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories
{
    public interface IServiceWriteRepository : IGenericWriteRepository<Service>
    {
    }
}
