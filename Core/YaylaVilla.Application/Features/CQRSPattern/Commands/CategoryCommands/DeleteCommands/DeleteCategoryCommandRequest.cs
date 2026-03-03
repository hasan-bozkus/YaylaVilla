using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.DeleteCommands
{
    public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
    {
        public int id { get; set; }
    }
}