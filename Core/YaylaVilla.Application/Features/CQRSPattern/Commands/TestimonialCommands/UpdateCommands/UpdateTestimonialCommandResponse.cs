namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.UpdateCommands
{
    public class UpdateTestimonialCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}