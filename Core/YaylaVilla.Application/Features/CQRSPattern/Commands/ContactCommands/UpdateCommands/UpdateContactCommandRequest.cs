using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.UpdateCommands
{
    public class UpdateContactCommandRequest : IRequest<UpdateContactCommandResponse>
    {
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}