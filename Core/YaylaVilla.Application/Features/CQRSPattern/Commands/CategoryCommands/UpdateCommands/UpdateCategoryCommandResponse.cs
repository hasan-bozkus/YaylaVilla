namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.UpdateCommands
{
    public class UpdateCategoryCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}