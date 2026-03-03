namespace YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.GetQueries
{
    public class GetCategoryQueryResponse
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}