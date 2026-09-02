using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetProductSpecialOfferListQueries
{
    internal class GetProductSpecialOfferListQueryHandler : IRequestHandler<GetProductSpecialOfferListQueryRequest, List<GetProductSpecialOfferListQueryResponse>>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public GetProductSpecialOfferListQueryHandler(IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<List<GetProductSpecialOfferListQueryResponse>> Handle(GetProductSpecialOfferListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<GetProductSpecialOfferListQueryResponse>>(await _productReadRepository.GetProductSpecialOfferListAsync());

            return values;
        }
    }
}
