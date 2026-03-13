namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.GetQueries
{
    public class GetAboutQueryResponse
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}