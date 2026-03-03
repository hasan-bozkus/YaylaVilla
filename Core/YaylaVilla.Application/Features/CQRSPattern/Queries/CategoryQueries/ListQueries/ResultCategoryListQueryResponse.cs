namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.ListQueries
{
    public class ResultCategoryListQueryResponse
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}