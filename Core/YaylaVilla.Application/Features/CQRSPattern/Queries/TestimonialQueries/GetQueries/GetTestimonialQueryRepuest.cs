using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.GetQueries
{
    public class GetTestimonialQueryRepuest : IRequest<GetTestimonialQueryResponse>
    {
        public int id { get; set; }
    }
}