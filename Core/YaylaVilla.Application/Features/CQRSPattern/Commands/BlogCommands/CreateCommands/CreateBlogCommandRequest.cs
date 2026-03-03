using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.CreateCommands
{
    public class CreateBlogCommandRequest : IRequest<CreateBlogCommandResponse>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}