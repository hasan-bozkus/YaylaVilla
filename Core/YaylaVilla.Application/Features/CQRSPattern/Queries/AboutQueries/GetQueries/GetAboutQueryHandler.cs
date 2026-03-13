using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.GetQueries
{
    internal class GetAboutQueryHandler : IRequestHandler<GetAboutQueryRepuest, GetAboutQueryResponse>
    {
        private readonly IAboutReadRepository _aboutReadRepository;
        private readonly IMapper _mapper;

        public GetAboutQueryHandler(IAboutReadRepository aboutReadRepository, IMapper mapper)
        {
            _aboutReadRepository = aboutReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAboutQueryResponse> Handle(GetAboutQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetAboutQueryResponse>(await _aboutReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
