using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.CreateCommands
{
    internal class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;
        private readonly IMapper _mapper;

        public CreateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IMapper mapper)
        {
            _aboutWriteRepository = aboutWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {            
            request.Status = false;

            var mapper = _mapper.Map<About>(request);
            await _aboutWriteRepository.CreateAsync(mapper);
            await _aboutWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
