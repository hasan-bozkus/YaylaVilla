using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.GetQueries
{
    internal class GetContactQueryHandler : IRequestHandler<GetContactQueryRepuest, GetContactQueryResponse>
    {
        private readonly IContactReadRepository _contactReadRepository;
        private readonly IMapper _mapper;

        public GetContactQueryHandler(IContactReadRepository contactReadRepository, IMapper mapper)
        {
            _contactReadRepository = contactReadRepository;
            _mapper = mapper;
        }

        public async Task<GetContactQueryResponse> Handle(GetContactQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetContactQueryResponse>(await _contactReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
