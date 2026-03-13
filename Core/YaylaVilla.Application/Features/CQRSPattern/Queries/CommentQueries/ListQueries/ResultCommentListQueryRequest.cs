using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.ListQueries
{
    public class ResultCommentListQueryRequest : IRequest<List<ResultCommentListQueryResponse>>
    {
    }
}