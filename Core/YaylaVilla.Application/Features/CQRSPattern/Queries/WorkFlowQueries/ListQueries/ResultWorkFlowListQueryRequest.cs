using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.ListQueries
{
    public class ResultWorkFlowListQueryRequest : IRequest<List<ResultWorkFlowListQueryResponse>>
    {
    }
}