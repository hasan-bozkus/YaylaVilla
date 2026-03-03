using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.DeleteCommands
{
    internal class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommandRequest, DeleteBlogCommandResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IBlogWriteRepository _blogWriteRepository;

        public DeleteBlogCommandHandler(IBlogReadRepository blogReadRepository, IBlogWriteRepository blogWriteRepository)
        {
            _blogReadRepository = blogReadRepository;
            _blogWriteRepository = blogWriteRepository;
        }

        public async Task<DeleteBlogCommandResponse> Handle(DeleteBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _blogReadRepository.GetByIDAsync(request.id);
            await _blogWriteRepository.DeleteAsync(result);
            await _blogWriteRepository.SaveChangesAsync();
            return new DeleteBlogCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
