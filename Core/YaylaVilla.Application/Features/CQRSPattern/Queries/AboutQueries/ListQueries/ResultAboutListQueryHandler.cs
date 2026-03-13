using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.ListQueries
{
    internal class ResultAboutListQueryHandler : IRequestHandler<ResultAboutListQueryRequest, List<ResultAboutListQueryResponse>>
    {
        private readonly IAboutReadRepository _aboutReadRepository;
        private readonly IMapper _mapper;

        public ResultAboutListQueryHandler(IAboutReadRepository aboutReadRepository, IMapper mapper)
        {
            _aboutReadRepository = aboutReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultAboutListQueryResponse>> Handle(ResultAboutListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultAboutListQueryResponse>>(await _aboutReadRepository.GetListAllAsync());
            return values;
        }
    }
}
