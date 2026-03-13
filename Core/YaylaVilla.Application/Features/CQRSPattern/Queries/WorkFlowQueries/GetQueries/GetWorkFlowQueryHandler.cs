using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.GetQueries;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.WorkflowQueries.GetQueries
{
    internal class GetWorkFlowQueryHandler : IRequestHandler<GetWorkFlowQueryRepuest, GetWorkFlowQueryResponse>
    {
        private readonly IWorkFlowReadRepository _workFlowReadRepository;
        private readonly IMapper _mapper;

        public GetWorkFlowQueryHandler(IWorkFlowReadRepository workFlowReadRepository, IMapper mapper)
        {
            _workFlowReadRepository = workFlowReadRepository;
            _mapper = mapper;
        }

        public async Task<GetWorkFlowQueryResponse> Handle(GetWorkFlowQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetWorkFlowQueryResponse>(await _workFlowReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
