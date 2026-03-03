namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.DeleteCommands
{
    public class DeleteTagCloudCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}