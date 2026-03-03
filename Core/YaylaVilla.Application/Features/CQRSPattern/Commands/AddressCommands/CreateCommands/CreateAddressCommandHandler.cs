using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.CreateCommands
{
    internal class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IAddressWriteRepository addressWriteRepository, IMapper mapper)
        {
            _addressWriteRepository = addressWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Address>(request);
            await _addressWriteRepository.CreateAsync(mapper);
            await _addressWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
