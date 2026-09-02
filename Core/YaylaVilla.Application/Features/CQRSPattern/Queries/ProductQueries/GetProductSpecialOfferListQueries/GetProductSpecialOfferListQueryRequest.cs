using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetProductSpecialOfferListQueries
{
    public class GetProductSpecialOfferListQueryRequest : IRequest<List<GetProductSpecialOfferListQueryResponse>>
    {
    }
}