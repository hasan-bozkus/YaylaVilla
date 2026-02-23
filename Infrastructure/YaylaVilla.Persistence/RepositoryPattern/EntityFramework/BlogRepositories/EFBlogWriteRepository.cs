using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.BlogRepositories
{
    public class EFBlogWriteRepository : GenericWriteRepository<Blog>, IBlogWriteRepository
    {
        public EFBlogWriteRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
