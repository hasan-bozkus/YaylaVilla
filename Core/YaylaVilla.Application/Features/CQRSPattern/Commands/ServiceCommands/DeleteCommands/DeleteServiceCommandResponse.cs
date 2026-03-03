namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.DeleteCommands
{
    public class DeleteServiceCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}