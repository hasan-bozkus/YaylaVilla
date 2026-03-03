using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.DeleteCommands
{
    public class DeleteAddressCommandRequest : IRequest<DeleteAddressCommandResponse>
    {
        public int id { get; set; }
    }
}