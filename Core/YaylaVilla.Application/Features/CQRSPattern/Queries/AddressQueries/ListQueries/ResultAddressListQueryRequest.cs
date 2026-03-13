using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.ListQueries
{
    public class ResultAddressListQueryRequest : IRequest<List<ResultAddressListQueryResponse>>
    {
    }
}