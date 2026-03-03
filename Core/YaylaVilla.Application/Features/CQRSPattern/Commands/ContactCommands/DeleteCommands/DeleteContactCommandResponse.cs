namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.DeleteCommands
{
    public class DeleteContactCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}