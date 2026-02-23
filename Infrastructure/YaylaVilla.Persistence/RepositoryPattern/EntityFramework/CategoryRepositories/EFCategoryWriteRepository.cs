using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.CategoryRepositories
{
    public class EFCategoryWriteRepository : GenericWriteRepository<Category>, ICategoryWriteRepository
    {
        public EFCategoryWriteRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
