namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.DeleteCommands
{
    public class DeleteCommentCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}