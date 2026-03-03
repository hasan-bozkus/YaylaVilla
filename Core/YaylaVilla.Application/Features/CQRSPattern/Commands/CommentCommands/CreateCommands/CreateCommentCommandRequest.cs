using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.CreateCommands
{
    public class CreateCommentCommandRequest : IRequest<CreateCommentCommandResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}