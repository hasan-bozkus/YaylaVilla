using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.AboutRepositories
{
    public class EFAboutReadRepository : GenericReadRepository<About>, IAboutReadRepository
    {
        public EFAboutReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
