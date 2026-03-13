using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.ListQueries
{
    public class ResultProductListQueryRequest : IRequest<List<ResultProductListQueryResponse>>
    {
    }
}