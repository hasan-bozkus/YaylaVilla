namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.CreateCommands
{
    public class CreateContactCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}