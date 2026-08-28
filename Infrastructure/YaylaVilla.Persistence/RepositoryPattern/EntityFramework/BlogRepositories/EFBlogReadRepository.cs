using Microsoft.EntityFrameworkCore;
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
        private readonly YaylaVillaContext _context;

        public EFBlogReadRepository(YaylaVillaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetLast4BlogListAsync()
        {
            var values = await _context.Blogs.OrderByDescending(x => x.BlogID).Take(4).ToListAsync();
            return values;
        }
    }
}
