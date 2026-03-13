using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.ListQueries
{
    public class ResultAboutListQueryRequest : IRequest<List<ResultAboutListQueryResponse>>
    {
    }
}