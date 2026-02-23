using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressReposiotries;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.AddressRepositories
{
    public class EFAddressWriteRepository : GenericWriteRepository<Address>, IAddressWriteRepository
    {
        public EFAddressWriteRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
