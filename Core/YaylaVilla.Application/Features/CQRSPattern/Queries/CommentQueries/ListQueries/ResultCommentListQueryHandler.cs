using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CommentRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.ListQueries
{
    internal class ResultCommentListQueryHandler : IRequestHandler<ResultCommentListQueryRequest, List<ResultCommentListQueryResponse>>
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly IMapper _mapper;

        public ResultCommentListQueryHandler(ICommentReadRepository commentReadRepository, IMapper mapper)
        {
            _commentReadRepository = commentReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultCommentListQueryResponse>> Handle(ResultCommentListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultCommentListQueryResponse>>(await _commentReadRepository.GetListAllAsync());
            return values;
        }
    }
}
