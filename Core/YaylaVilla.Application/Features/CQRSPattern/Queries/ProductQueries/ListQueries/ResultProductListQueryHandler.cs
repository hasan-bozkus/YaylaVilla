using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.ListQueries
{
    internal class ResultProductListQueryHandler : IRequestHandler<ResultProductListQueryRequest, List<ResultProductListQueryResponse>>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public ResultProductListQueryHandler(IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultProductListQueryResponse>> Handle(ResultProductListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultProductListQueryResponse>>(await _productReadRepository.GetListAllAsync());
            return values;
        }
    }
}
