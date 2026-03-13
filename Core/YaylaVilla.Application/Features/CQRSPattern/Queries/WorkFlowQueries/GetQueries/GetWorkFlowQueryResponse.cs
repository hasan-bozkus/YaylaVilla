namespace YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.GetQueries
{
    public class GetWorkFlowQueryResponse
    {
        public int WorkFlowID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}