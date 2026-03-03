using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.ListQueries
{
    public class ResultCategoryListQueryRequest : IRequest<List<ResultCategoryListQueryResponse>>
    {
    }
}