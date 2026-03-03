using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.DeleteCommands
{
    internal class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommandRequest, DeleteAboutCommandResponse>
    {
        private readonly IAboutReadRepository _aboutReadRepository;
        private readonly IAboutWriteRepository _aboutWriteRepository;

        public DeleteAboutCommandHandler(IAboutReadRepository aboutReadRepository, IAboutWriteRepository aboutWriteRepository)
        {
            _aboutReadRepository = aboutReadRepository;
            _aboutWriteRepository = aboutWriteRepository;
        }

        public async Task<DeleteAboutCommandResponse> Handle(DeleteAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _aboutReadRepository.GetByIDAsync(request.id);
            await _aboutWriteRepository.DeleteAsync(result);
            await _aboutWriteRepository.SaveChangesAsync();
            return new DeleteAboutCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
