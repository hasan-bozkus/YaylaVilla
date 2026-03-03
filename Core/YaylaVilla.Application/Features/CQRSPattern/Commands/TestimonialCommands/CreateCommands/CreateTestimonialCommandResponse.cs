namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.CreateCommands
{
    public class CreateTestimonialCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}