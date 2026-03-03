using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.DeleteCommands
{
    public class DeleteBlogCommandRequest : IRequest<DeleteBlogCommandResponse>
    {
        public int id { get; set; }
    }
}