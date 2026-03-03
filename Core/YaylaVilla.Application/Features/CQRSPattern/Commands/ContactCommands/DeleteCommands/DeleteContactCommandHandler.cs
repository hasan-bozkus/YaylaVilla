using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.DeleteCommands
{
    internal class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommandRequest, DeleteContactCommandResponse>
    {
        private readonly IContactReadRepository _contactReadRepository;
        private readonly IContactWriteRepository _contactWriteRepository;

        public DeleteContactCommandHandler(IContactReadRepository contactReadRepository, IContactWriteRepository contactWriteRepository)
        {
            _contactReadRepository = contactReadRepository;
            _contactWriteRepository = contactWriteRepository;
        }

        public async Task<DeleteContactCommandResponse> Handle(DeleteContactCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _contactReadRepository.GetByIDAsync(request.id);
            await _contactWriteRepository.DeleteAsync(result);
            await _contactWriteRepository.SaveChangesAsync();
            return new DeleteContactCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
