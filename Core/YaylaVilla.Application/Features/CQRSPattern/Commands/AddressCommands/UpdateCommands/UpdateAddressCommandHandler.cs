using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.UpdateCommands
{
    internal class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressCommandResponse>
    {
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IMapper _mapper;

        public UpdateAddressCommandHandler(IAddressWriteRepository addressWriteRepository, IMapper mapper)
        {
            _addressWriteRepository = addressWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Address>(request);
            await _addressWriteRepository.UpdateAsync(mapper);
            await _addressWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
