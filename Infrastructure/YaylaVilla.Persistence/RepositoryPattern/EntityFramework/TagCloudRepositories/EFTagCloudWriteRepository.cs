using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TagCloudRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.TagCloudRepositories
{
    public class EFTagCloudWriteRepository : GenericWriteRepository<TagCloud>, ITagCloudWriteRepository
    {
        public EFTagCloudWriteRepository(YaylaVillaContext context) : base(context)
        {
        }
    
    }
}
