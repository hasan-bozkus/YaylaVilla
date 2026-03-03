using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.UpdateCommands
{
    public class UpdateTagCloudCommandRequest : IRequest<UpdateTagCloudCommandResponse>
    {
        public int TagCloudID { get; set; }
        public string TagName { get; set; }
    }
}