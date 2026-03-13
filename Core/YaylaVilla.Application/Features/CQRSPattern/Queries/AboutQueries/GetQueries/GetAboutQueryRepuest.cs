using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.GetQueries
{
    public class GetAboutQueryRepuest : IRequest<GetAboutQueryResponse>
    {
        public int id { get; set; }
    }
}