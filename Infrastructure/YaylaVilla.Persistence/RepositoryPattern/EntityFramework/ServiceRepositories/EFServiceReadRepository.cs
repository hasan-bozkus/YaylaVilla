using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ServiceRepositories
{
    public class EFServiceReadRepository : GenericReadRepository<Service>, IServiceReadRepository
    {
        public EFServiceReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
