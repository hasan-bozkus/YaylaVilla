using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CommentRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.CreateCommands
{
    internal class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommandRequest, CreateCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly IMapper _mapper;

        public CreateCommentCommandHandler(ICommentWriteRepository commentWriteRepository, IMapper mapper)
        {
            _commentWriteRepository = commentWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Comment>(request);
            await _commentWriteRepository.CreateAsync(mapper);
            await _commentWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
