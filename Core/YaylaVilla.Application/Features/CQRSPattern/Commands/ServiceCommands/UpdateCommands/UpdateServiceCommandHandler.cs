using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.UpdateCommands
{
    internal class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommandRequest, UpdateServiceCommandResponse>
    {
        private readonly IServiceWriteRepository _serviceWriteRepository;
        private readonly IMapper _mapper;

        public UpdateServiceCommandHandler(IServiceWriteRepository serviceWriteRepository, IMapper mapper)
        {
            _serviceWriteRepository = serviceWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateServiceCommandResponse> Handle(UpdateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Service>(request);
            await _serviceWriteRepository.UpdateAsync(mapper);
            await _serviceWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
