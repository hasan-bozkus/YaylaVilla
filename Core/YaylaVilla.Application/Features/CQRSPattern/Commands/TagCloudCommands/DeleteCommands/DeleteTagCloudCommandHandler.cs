using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TagCloudRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.DeleteCommands
{
    internal class DeleteTagCloudCommandHandler : IRequestHandler<DeleteTagCloudCommandRequest, DeleteTagCloudCommandResponse>
    {
        private readonly ITagCloudReadRepository _tagCloudReadRepository;
        private readonly ITagCloudWriteRepository _tagCloudWriteRepository;

        public DeleteTagCloudCommandHandler(ITagCloudReadRepository tagCloudReadRepository, ITagCloudWriteRepository tagCloudWriteRepository)
        {
            _tagCloudReadRepository = tagCloudReadRepository;
            _tagCloudWriteRepository = tagCloudWriteRepository;
        }

        public async Task<DeleteTagCloudCommandResponse> Handle(DeleteTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _tagCloudReadRepository.GetByIDAsync(request.id);
            await _tagCloudWriteRepository.DeleteAsync(result);
            await _tagCloudWriteRepository.SaveChangesAsync();
            return new DeleteTagCloudCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
