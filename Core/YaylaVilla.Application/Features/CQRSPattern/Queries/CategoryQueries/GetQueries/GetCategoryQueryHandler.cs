using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.GetQueries
{
    internal class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRepuest, GetCategoryQueryResponse>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _mapper = mapper;
        }

        public async Task<GetCategoryQueryResponse> Handle(GetCategoryQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetCategoryQueryResponse>(await _categoryReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
