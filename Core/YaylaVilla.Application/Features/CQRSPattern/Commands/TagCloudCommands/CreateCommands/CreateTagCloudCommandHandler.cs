using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TagCloudRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.CreateCommands
{
    internal class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommandRequest, CreateTagCloudCommandResponse>
    {
        private readonly ITagCloudWriteRepository _tagCloudWriteRepository;
        private readonly IMapper _mapper;

        public CreateTagCloudCommandHandler(ITagCloudWriteRepository tagCloudWriteRepository, IMapper mapper)
        {
            _tagCloudWriteRepository = tagCloudWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateTagCloudCommandResponse> Handle(CreateTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<TagCloud>(request);
            await _tagCloudWriteRepository.CreateAsync(mapper);
            await _tagCloudWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
