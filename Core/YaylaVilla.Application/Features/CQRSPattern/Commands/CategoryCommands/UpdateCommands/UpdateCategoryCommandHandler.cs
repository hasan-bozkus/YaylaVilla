using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.UpdateCommands
{
    internal class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Category>(request);
            await _categoryWriteRepository.UpdateAsync(mapper);
            await _categoryWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
