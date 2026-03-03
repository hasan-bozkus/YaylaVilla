using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.UpdateCommands
{
    public class UpdateCommentCommandRequest : IRequest<UpdateCommentCommandResponse>
    {
        public int CommentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}