using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.DeleteCommands
{
    internal class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommandRequest, DeleteServiceCommandResponse>
    {
        private readonly IServiceReadRepository _serviceReadRepository;
        private readonly IServiceWriteRepository _serviceWriteRepository;

        public DeleteServiceCommandHandler(IServiceReadRepository serviceReadRepository, IServiceWriteRepository serviceWriteRepository)
        {
            _serviceReadRepository = serviceReadRepository;
            _serviceWriteRepository = serviceWriteRepository;
        }

        public async Task<DeleteServiceCommandResponse> Handle(DeleteServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _serviceReadRepository.GetByIDAsync(request.id);
            await _serviceWriteRepository.DeleteAsync(result);
            await _serviceWriteRepository.SaveChangesAsync();
            return new DeleteServiceCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
