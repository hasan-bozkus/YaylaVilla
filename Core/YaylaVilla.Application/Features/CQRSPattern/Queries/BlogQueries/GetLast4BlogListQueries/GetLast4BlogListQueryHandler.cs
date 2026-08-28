using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetLast4BlogListQueries
{
    internal class GetLast4BlogListQueryHandler : IRequestHandler<GetLast4BlogListQueryRequest, List<GetLast4BlogListQueryResponse>>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IMapper _mapper;

        public GetLast4BlogListQueryHandler(IBlogReadRepository blogReadRepository, IMapper mapper)
        {
            _blogReadRepository = blogReadRepository;
            _mapper = mapper;
        }

        public async Task<List<GetLast4BlogListQueryResponse>> Handle(GetLast4BlogListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<GetLast4BlogListQueryResponse>>(await _blogReadRepository.GetLast4BlogListAsync());
            return values;
        }
    }
}
