using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.ListQueries
{
    internal class ResultCategoryListQueryHandler : IRequestHandler<ResultCategoryListQueryRequest, List<ResultCategoryListQueryResponse>>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly IMapper _mapper;

        public ResultCategoryListQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultCategoryListQueryResponse>> Handle(ResultCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultCategoryListQueryResponse>>(await _categoryReadRepository.GetListAllAsync());
            return values;
        }
    }
}
