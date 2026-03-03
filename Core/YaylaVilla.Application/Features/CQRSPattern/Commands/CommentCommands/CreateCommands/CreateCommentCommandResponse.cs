namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.CreateCommands
{
    public class CreateCommentCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}