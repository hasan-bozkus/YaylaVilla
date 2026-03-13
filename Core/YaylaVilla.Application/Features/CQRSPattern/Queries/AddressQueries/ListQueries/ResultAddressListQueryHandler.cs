using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.ListQueries
{
    internal class ResultAddressListQueryHandler : IRequestHandler<ResultAddressListQueryRequest, List<ResultAddressListQueryResponse>>
    {
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IMapper _mapper;

        public ResultAddressListQueryHandler(IAddressReadRepository addressReadRepository, IMapper mapper)
        {
            _addressReadRepository = addressReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultAddressListQueryResponse>> Handle(ResultAddressListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultAddressListQueryResponse>>(await _addressReadRepository.GetListAllAsync());
            return values;
        }
    }
}
