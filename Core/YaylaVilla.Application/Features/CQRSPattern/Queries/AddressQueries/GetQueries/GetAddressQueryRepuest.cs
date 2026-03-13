using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.GetQueries
{
    public class GetAddressQueryRepuest : IRequest<GetAddressQueryResponse>
    {
        public int id { get; set; }
    }
}