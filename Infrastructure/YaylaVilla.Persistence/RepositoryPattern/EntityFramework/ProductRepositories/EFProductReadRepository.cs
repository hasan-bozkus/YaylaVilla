using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ProductRepositories
{
    public class EFProductReadRepository : GenericReadRepository<Product>, IProductReadRepository
    {
        public EFProductReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
