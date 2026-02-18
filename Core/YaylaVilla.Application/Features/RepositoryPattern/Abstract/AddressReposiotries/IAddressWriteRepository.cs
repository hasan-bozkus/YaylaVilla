using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressReposiotries
{
    public interface IAddressWriteRepository : IGenericWriteRepository<Address>
    {
    }
}
