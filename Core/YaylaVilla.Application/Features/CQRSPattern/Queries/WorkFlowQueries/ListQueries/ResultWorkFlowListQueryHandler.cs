using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.ListQueries
{
    internal class ResultWorkFlowListQueryHandler : IRequestHandler<ResultWorkFlowListQueryRequest, List<ResultWorkFlowListQueryResponse>>
    {
        private readonly IWorkFlowReadRepository _workFlowReadRepository;
        private readonly IMapper _mapper;

        public ResultWorkFlowListQueryHandler(IWorkFlowReadRepository workFlowReadRepository, IMapper mapper)
        {
            _workFlowReadRepository = workFlowReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultWorkFlowListQueryResponse>> Handle(ResultWorkFlowListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultWorkFlowListQueryResponse>>(await _workFlowReadRepository.GetListAllAsync());
            return values;
        }
    }
}
