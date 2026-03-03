using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.UpdateCommands
{
    internal class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommandRequest, UpdateContactCommandResponse>
    {
        private readonly IContactWriteRepository _contactWriteRepository;
        private readonly IMapper _mapper;

        public UpdateContactCommandHandler(IContactWriteRepository contactWriteRepository, IMapper mapper)
        {
            _contactWriteRepository = contactWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateContactCommandResponse> Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Contact>(request);
            await _contactWriteRepository.UpdateAsync(mapper);
            await _contactWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
