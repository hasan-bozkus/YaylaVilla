using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.ListQueries
{
    public class ResultTestimonialListQueryRequest : IRequest<List<ResultTestimonialListQueryResponse>>
    {
    }
}