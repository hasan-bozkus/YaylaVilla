namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetQueries
{
    public class GetBlogQueryResponse
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}