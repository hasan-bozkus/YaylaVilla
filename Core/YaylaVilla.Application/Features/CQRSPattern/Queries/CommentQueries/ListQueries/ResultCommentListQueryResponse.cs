namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.ListQueries
{
    public class ResultCommentListQueryResponse
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string CommentDetail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsToxic { get; set; }
        public bool Sttaus { get; set; }
    }
}