using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.GetQueries
{
    public class GetContactQueryRepuest : IRequest<GetContactQueryResponse>
    {
        public int id { get; set; }
    }
}