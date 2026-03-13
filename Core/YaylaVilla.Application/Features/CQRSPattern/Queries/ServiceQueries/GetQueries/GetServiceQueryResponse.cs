namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.GetQueries
{
    public class GetServiceQueryResponse
    {
        public int ServiceID { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}