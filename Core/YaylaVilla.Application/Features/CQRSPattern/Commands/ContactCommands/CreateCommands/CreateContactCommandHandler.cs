using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.CreateCommands
{
    internal class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest, CreateContactCommandResponse>
    {
        private readonly IContactWriteRepository _contactWriteRepository;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IContactWriteRepository contactWriteRepository, IMapper mapper)
        {
            _contactWriteRepository = contactWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Contact>(request);
            await _contactWriteRepository.CreateAsync(mapper);
            await _contactWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
