using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TestimonialRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.UpdateCommands
{
    internal class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommandRequest, UpdateTestimonialCommandResponse>
    {
        private readonly ITestimonialWriteRepository _testimonialWriteRepository;
        private readonly IMapper _mapper;

        public UpdateTestimonialCommandHandler(ITestimonialWriteRepository testimonialWriteRepository, IMapper mapper)
        {
            _testimonialWriteRepository = testimonialWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateTestimonialCommandResponse> Handle(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Testimonial>(request);
            await _testimonialWriteRepository.UpdateAsync(mapper);
            await _testimonialWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
