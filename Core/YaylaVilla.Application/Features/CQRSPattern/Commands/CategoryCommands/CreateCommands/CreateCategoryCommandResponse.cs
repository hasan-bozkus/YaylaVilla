namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.CreateCommands
{
    public class CreateCategoryCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}