using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.ListQueries
{
    public class ResultServiceListQueryRequest : IRequest<List<ResultServiceListQueryResponse>>
    {
    }
}