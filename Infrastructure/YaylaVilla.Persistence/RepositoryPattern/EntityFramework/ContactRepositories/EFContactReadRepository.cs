using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ContactRepositories
{
    public class EFContactReadRepository : GenericReadRepository<Contact>, IContactReadRepository
    {
        public EFContactReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
