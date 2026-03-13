namespace YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.GetQueries
{
    public class GetContactQueryResponse
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}