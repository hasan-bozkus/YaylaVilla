using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.UpdateCommands
{
    internal class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommandRequest, UpdateBlogCommandResponse>
    {
        private readonly IBlogWriteRepository _blogWriteRepository;
        private readonly IMapper _mapper;

        public UpdateBlogCommandHandler(IBlogWriteRepository blogWriteRepository, IMapper mapper)
        {
            _blogWriteRepository = blogWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateBlogCommandResponse> Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<Blog>(request);
            await _blogWriteRepository.UpdateAsync(mapper);
            await _blogWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
