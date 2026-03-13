using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.ListQueries
{
    public class ResultTagCloudListQueryRequest : IRequest<List<ResultTagCloudListQueryResponse>>
    {
    }
}