namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.DeleteCommands
{
    public class DeleteProductCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}