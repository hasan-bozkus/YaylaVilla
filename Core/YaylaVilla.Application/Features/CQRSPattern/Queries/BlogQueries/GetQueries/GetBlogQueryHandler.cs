using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetQueries
{
    internal class GetBlogQueryHandler : IRequestHandler<GetBlogQueryRepuest, GetBlogQueryResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IMapper _mapper;

        public GetBlogQueryHandler(IBlogReadRepository blogReadRepository, IMapper mapper)
        {
            _blogReadRepository = blogReadRepository;
            _mapper = mapper;
        }

        public async Task<GetBlogQueryResponse> Handle(GetBlogQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetBlogQueryResponse>(await _blogReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
