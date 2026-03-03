using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.DeleteCommands
{
    public class DeleteTagCloudCommandRequest : IRequest<DeleteTagCloudCommandResponse>
    {
        public int id { get; set; }
    }
}