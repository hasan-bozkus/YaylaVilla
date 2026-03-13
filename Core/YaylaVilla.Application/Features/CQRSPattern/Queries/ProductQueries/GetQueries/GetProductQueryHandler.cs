using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetQueries
{
    internal class GetProductQueryHandler : IRequestHandler<GetProductQueryRepuest, GetProductQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<GetProductQueryResponse> Handle(GetProductQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetProductQueryResponse>(await _productReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
