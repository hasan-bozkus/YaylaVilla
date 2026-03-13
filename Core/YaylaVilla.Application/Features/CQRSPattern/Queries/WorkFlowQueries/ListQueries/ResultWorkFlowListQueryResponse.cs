namespace YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.ListQueries
{
    public class ResultWorkFlowListQueryResponse
    {
        public int WorkFlowID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}