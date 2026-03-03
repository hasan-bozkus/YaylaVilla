using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.UpdateCommands
{
    internal class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommandRequest, UpdateAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;
        private readonly IMapper _mapper;

        public UpdateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IMapper mapper)
        {
            _aboutWriteRepository = aboutWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateAboutCommandResponse> Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<About>(request);
            await _aboutWriteRepository.UpdateAsync(mapper);
            await _aboutWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
