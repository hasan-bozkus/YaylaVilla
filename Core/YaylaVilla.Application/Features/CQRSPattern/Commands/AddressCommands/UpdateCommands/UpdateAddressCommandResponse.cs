namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.UpdateCommands
{
    public class UpdateAddressCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}