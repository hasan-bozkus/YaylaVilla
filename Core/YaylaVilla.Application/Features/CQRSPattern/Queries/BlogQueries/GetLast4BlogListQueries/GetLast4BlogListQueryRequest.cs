using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetLast4BlogListQueries
{
    public class GetLast4BlogListQueryRequest : IRequest<List<GetLast4BlogListQueryResponse>>
    {
    }
}