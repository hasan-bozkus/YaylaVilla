namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.UpdateCommands
{
    public class UpdateProductCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}