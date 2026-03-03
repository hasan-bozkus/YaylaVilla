namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.UpdateCommands
{
    public class UpdateBlogCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}