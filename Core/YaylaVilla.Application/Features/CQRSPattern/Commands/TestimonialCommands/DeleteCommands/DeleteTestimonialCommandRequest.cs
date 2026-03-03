using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.DeleteCommands
{
    public class DeleteTestimonialCommandRequest : IRequest<DeleteTestimonialCommandResponse>
    {
        public int id { get; set; }
    }
}