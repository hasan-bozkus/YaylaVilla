using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.GetQueries
{
    internal class GetServiceQueryHandler : IRequestHandler<GetServiceQueryRepuest, GetServiceQueryResponse>
    {
        private readonly IServiceReadRepository _serviceReadRepository;
        private readonly IMapper _mapper;

        public GetServiceQueryHandler(IServiceReadRepository serviceReadRepository, IMapper mapper)
        {
            _serviceReadRepository = serviceReadRepository;
            _mapper = mapper;
        }

        public async Task<GetServiceQueryResponse> Handle(GetServiceQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetServiceQueryResponse>(await _serviceReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
