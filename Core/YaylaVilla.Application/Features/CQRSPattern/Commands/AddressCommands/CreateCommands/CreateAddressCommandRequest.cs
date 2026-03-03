using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.CreateCommands
{
    public class CreateAddressCommandRequest : IRequest<CreateAddressCommandResponse>
    {
        public string MapLocation { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}