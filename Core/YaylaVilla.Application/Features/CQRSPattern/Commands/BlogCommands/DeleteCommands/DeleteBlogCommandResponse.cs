namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.DeleteCommands
{
    public class DeleteBlogCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}