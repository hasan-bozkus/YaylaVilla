using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.ListQueries
{
    public class ResultContactListQueryRequest : IRequest<List<ResultContactListQueryResponse>>
    {
    }
}