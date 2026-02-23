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
    public class EFContactWriteRepository : GenericWriteRepository<Contact>, IContactWriteRepository
    {
        public EFContactWriteRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
