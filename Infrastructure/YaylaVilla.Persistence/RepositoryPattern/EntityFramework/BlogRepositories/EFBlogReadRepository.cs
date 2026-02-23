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
    public class EFBlogReadRepository : GenericReadRepository<Blog>, IBlogReadRepository
    {
        public EFBlogReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
