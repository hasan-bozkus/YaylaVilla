using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.CreateCommands
{
    public class CreateContactCommandRequest : IRequest<CreateContactCommandResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}