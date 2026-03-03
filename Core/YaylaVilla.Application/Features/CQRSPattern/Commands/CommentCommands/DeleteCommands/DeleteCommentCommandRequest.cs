using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.DeleteCommands
{
    public class DeleteCommentCommandRequest : IRequest<DeleteCommentCommandResponse>
    {
        public int id { get; set; }
    }
}