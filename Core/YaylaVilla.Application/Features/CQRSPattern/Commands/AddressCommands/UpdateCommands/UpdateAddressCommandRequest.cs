using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.UpdateCommands
{
    public class UpdateAddressCommandRequest : IRequest<UpdateAddressCommandResponse>
    {
        public int AddressID { get; set; }
        public string MapLocation { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}