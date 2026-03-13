namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.ListQueries
{
    public class ResultTestimonialListQueryResponse
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
    }
}