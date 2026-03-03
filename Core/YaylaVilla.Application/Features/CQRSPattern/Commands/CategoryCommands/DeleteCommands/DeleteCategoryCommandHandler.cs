using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.DeleteCommands
{
    internal class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public DeleteCategoryCommandHandler(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _categoryReadRepository.GetByIDAsync(request.id);
            await _categoryWriteRepository.DeleteAsync(result);
            await _categoryWriteRepository.SaveChangesAsync();
            return new DeleteCategoryCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
