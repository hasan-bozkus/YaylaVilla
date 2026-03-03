namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.DeleteCommands
{
    public class DeleteAddressCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}