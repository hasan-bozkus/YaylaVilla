using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TestimonialRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.TestimonialRepositroies
{
    public class EFTestimonialReadRepository : GenericReadRepository<Testimonial>, ITestimonialReadRepository
    {
        public EFTestimonialReadRepository(YaylaVillaContext context) : base(context)
        {
        }
    }
}
