namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.CreateCommands
{
    public class CreateAddressCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}