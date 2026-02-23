using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.WorkFlowRepositories
{
    public class EFWorkFlowReadRepository : GenericReadRepository<WorkFlow>, IWorkFlowReadRepository
    {
        public EFWorkFlowReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
