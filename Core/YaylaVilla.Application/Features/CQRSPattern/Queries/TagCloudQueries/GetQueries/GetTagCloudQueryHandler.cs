using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TagCloudRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.GetQueries
{
    internal class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQueryRepuest, GetTagCloudQueryResponse>
    {
        private readonly ITagCloudReadRepository _tagCloudReadRepository;
        private readonly IMapper _mapper;

        public GetTagCloudQueryHandler(ITagCloudReadRepository tagCloudReadRepository, IMapper mapper)
        {
            _tagCloudReadRepository = tagCloudReadRepository;
            _mapper = mapper;
        }

        public async Task<GetTagCloudQueryResponse> Handle(GetTagCloudQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetTagCloudQueryResponse>(await _tagCloudReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
