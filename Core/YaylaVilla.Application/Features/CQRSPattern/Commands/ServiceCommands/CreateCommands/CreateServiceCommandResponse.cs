namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.CreateCommands
{
    public class CreateServiceCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}