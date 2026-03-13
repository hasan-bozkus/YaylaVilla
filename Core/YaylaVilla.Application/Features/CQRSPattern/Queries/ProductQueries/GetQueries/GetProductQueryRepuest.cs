using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetQueries
{
    public class GetProductQueryRepuest : IRequest<GetProductQueryResponse>
    {
        public int id { get; set; }
    }
}