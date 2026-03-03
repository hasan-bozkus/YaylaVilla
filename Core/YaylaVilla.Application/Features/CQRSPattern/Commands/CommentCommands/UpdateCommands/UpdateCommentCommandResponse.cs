namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.UpdateCommands
{
    public class UpdateCommentCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}