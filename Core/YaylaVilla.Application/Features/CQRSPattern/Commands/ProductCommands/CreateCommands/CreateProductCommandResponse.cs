namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.CreateCommands
{
    public class CreateProductCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}