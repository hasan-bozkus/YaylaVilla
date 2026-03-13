using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.ListQueries
{
    internal class ResultBlogListQueryHandler : IRequestHandler<ResultBlogListQueryRequest, List<ResultBlogListQueryResponse>>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IMapper _mapper;

        public ResultBlogListQueryHandler(IBlogReadRepository blogReadRepository, IMapper mapper)
        {
            _blogReadRepository = blogReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultBlogListQueryResponse>> Handle(ResultBlogListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultBlogListQueryResponse>>(await _blogReadRepository.GetListAllAsync());
            return values;
        }
    }
}
