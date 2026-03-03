using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CommentRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.DeleteCommands
{
    internal class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommandRequest, DeleteCommentCommandResponse>
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly ICommentWriteRepository _commentWriteRepository;

        public DeleteCommentCommandHandler(ICommentReadRepository commentReadRepository, ICommentWriteRepository commentWriteRepository)
        {
            _commentReadRepository = commentReadRepository;
            _commentWriteRepository = commentWriteRepository;
        }

        public async Task<DeleteCommentCommandResponse> Handle(DeleteCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _commentReadRepository.GetByIDAsync(request.id);
            await _commentWriteRepository.DeleteAsync(result);
            await _commentWriteRepository.SaveChangesAsync();
            return new DeleteCommentCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
