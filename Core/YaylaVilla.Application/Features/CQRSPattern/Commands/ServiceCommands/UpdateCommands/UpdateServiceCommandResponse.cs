namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.UpdateCommands
{
    public class UpdateServiceCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}