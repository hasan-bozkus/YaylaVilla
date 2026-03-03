using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.UpdateCommands
{
    public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}