using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.GetQueries
{
    internal class GetAddressQueryHandler : IRequestHandler<GetAddressQueryRepuest, GetAddressQueryResponse>
    {
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IMapper _mapper;

        public GetAddressQueryHandler(IAddressReadRepository addressReadRepository, IMapper mapper)
        {
            _addressReadRepository = addressReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAddressQueryResponse> Handle(GetAddressQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetAddressQueryResponse>(await _addressReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
