using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.DeleteCommands
{
    internal class DeleteAddressCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryReadRepository _addressReadRepository;
        private readonly ICategoryWriteRepository _addressWriteRepository;

        public DeleteAddressCommandHandler(ICategoryReadRepository addressReadRepository, ICategoryWriteRepository addressWriteRepository)
        {
            _addressReadRepository = addressReadRepository;
            _addressWriteRepository = addressWriteRepository;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _addressReadRepository.GetByIDAsync(request.id);
            await _addressWriteRepository.DeleteAsync(result);
            await _addressWriteRepository.SaveChangesAsync();
            return new DeleteCategoryCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
