namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.DeleteCommands
{
    public class DeleteTestimonialCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}