using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.DeleteCommands
{
    internal class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommandRequest, DeleteAddressCommandResponse>
    {
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IAddressWriteRepository _addressWriteRepository;

        public DeleteAddressCommandHandler(IAddressReadRepository addressReadRepository, IAddressWriteRepository addressWriteRepository)
        {
            _addressReadRepository = addressReadRepository;
            _addressWriteRepository = addressWriteRepository;
        }

        public async Task<DeleteAddressCommandResponse> Handle(DeleteAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _addressReadRepository.GetByIDAsync(request.id);
            await _addressWriteRepository.DeleteAsync(result);
            await _addressWriteRepository.SaveChangesAsync();
            return new DeleteAddressCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
        }
    }
}
