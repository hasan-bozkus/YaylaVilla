using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.CreateCommands
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public string CategoryName { get; set; }
    }
}