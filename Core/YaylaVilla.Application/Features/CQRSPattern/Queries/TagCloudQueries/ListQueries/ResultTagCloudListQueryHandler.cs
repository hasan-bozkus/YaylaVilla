using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TagCloudRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.ListQueries
{
    internal class ResultTagCloudListQueryHandler : IRequestHandler<ResultTagCloudListQueryRequest, List<ResultTagCloudListQueryResponse>>
    {
        private readonly ITagCloudReadRepository _tagCloudReadRepository;
        private readonly IMapper _mapper;

        public ResultTagCloudListQueryHandler(ITagCloudReadRepository tagCloudReadRepository, IMapper mapper)
        {
            _tagCloudReadRepository = tagCloudReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultTagCloudListQueryResponse>> Handle(ResultTagCloudListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultTagCloudListQueryResponse>>(await _tagCloudReadRepository.GetListAllAsync());
            return values;
        }
    }
}
