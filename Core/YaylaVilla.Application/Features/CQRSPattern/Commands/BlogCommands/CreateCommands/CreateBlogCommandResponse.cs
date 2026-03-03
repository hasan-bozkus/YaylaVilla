namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.CreateCommands
{
    public class CreateBlogCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}