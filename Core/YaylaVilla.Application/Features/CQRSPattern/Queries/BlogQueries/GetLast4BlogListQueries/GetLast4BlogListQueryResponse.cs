namespace YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetLast4BlogListQueries
{
    public class GetLast4BlogListQueryResponse
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}