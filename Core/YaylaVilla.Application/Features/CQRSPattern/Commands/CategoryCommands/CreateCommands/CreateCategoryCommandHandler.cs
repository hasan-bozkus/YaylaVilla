using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.CreateCommands
{
    internal class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Category>(request);
            await _categoryWriteRepository.CreateAsync(mapper);
            await _categoryWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true
            };
        }
    }
}
