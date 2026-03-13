using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.ListQueries
{
    internal class ResultServiceListQueryHandler : IRequestHandler<ResultServiceListQueryRequest, List<ResultServiceListQueryResponse>>
    {
        private readonly IServiceReadRepository _serviceReadRepository;
        private readonly IMapper _mapper;

        public ResultServiceListQueryHandler(IServiceReadRepository serviceReadRepository, IMapper mapper)
        {
            _serviceReadRepository = serviceReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultServiceListQueryResponse>> Handle(ResultServiceListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultServiceListQueryResponse>>(await _serviceReadRepository.GetListAllAsync());
            return values;
        }
    }
}
