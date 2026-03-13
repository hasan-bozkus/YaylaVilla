using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.ListQueries
{
    internal class ResultContactListQueryHandler : IRequestHandler<ResultContactListQueryRequest, List<ResultContactListQueryResponse>>
    {
        private readonly IContactReadRepository _contactReadRepository;
        private readonly IMapper _mapper;

        public ResultContactListQueryHandler(IContactReadRepository contactReadRepository, IMapper mapper)
        {
            _contactReadRepository = contactReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultContactListQueryResponse>> Handle(ResultContactListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultContactListQueryResponse>>(await _contactReadRepository.GetListAllAsync());
            return values;
        }
    }
}
