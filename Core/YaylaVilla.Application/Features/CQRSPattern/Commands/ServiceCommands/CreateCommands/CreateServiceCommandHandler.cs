using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.CreateCommands
{
    internal class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommandRequest, CreateServiceCommandResponse>
    {
        private readonly IServiceWriteRepository _serviceWriteRepository;
        private readonly IMapper _mapper;

        public CreateServiceCommandHandler(IServiceWriteRepository serviceWriteRepository, IMapper mapper)
        {
            _serviceWriteRepository = serviceWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateServiceCommandResponse> Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Service>(request);
            await _serviceWriteRepository.CreateAsync(mapper);
            await _serviceWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
