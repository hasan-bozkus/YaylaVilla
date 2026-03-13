using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.GetQueries
{
    public class GetServiceQueryRepuest : IRequest<GetServiceQueryResponse>
    {
        public int id { get; set; }
    }
}