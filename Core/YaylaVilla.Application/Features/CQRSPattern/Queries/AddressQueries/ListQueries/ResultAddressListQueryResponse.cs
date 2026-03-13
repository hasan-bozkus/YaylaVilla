namespace YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.ListQueries
{
    public class ResultAddressListQueryResponse
    {
        public int AddressID { get; set; }
        public string MapLocation { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}