using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.CreateCommands
{
    public class CreateTagCloudCommandRequest : IRequest<CreateTagCloudCommandResponse>
    {
        public string TagName { get; set; }
    }
}