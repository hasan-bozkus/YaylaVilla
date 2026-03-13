using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.GetQueries
{
    public class GetCommentQueryRepuest : IRequest<GetCommentQueryResponse>
    {
        public int id { get; set; }
    }
}