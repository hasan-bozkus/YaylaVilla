using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.GetQueries
{
    public class GetCategoryQueryRepuest : IRequest<GetCategoryQueryResponse>
    {
        public int id { get; set; }
    }
}