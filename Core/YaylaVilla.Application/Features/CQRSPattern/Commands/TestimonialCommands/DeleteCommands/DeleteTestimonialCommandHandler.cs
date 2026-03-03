using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TestimonialRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.DeleteCommands
{
    internal class DeleteTestimonialCommandHandler : IRequestHandler<DeleteTestimonialCommandRequest, DeleteTestimonialCommandResponse>
    {
        private readonly ITestimonialReadRepository _testimonialReadRepository;
        private readonly ITestimonialWriteRepository _testimonialWriteRepository;

        public DeleteTestimonialCommandHandler(ITestimonialReadRepository testimonialReadRepository, ITestimonialWriteRepository testimonialWriteRepository)
        {
            _testimonialReadRepository = testimonialReadRepository;
            _testimonialWriteRepository = testimonialWriteRepository;
        }

        public async Task<DeleteTestimonialCommandResponse> Handle(DeleteTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _testimonialReadRepository.GetByIDAsync(request.id);
            await _testimonialWriteRepository.DeleteAsync(result);
            await _testimonialWriteRepository.SaveChangesAsync();
            return new DeleteTestimonialCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
