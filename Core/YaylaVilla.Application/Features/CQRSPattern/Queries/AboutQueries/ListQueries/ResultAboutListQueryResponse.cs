namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.ListQueries
{
    public class ResultAboutListQueryResponse
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}