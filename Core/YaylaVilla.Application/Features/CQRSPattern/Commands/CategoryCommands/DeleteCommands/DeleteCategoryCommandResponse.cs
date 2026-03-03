namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.DeleteCommands
{
    public class DeleteCategoryCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}