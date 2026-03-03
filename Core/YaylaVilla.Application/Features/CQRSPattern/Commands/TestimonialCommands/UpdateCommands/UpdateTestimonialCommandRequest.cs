using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.UpdateCommands
{
    public class UpdateTestimonialCommandRequest : IRequest<UpdateTestimonialCommandResponse>
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
    }
}