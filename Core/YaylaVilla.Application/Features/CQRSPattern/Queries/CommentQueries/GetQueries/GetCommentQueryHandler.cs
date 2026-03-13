using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CommentRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.GetQueries
{
    internal class GetCommentQueryHandler : IRequestHandler<GetCommentQueryRepuest, GetCommentQueryResponse>
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly IMapper _mapper;

        public GetCommentQueryHandler(ICommentReadRepository commentReadRepository, IMapper mapper)
        {
            _commentReadRepository = commentReadRepository;
            _mapper = mapper;
        }

        public async Task<GetCommentQueryResponse> Handle(GetCommentQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetCommentQueryResponse>(await _commentReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
