using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetQueries
{
    public class GetBlogQueryRepuest : IRequest<GetBlogQueryResponse>
    {
        public int id { get; set; }
    }
}