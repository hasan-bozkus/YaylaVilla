using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.ListQueries
{
    public class ResultBlogListQueryRequest : IRequest<List<ResultBlogListQueryResponse>>
    {
    }
}