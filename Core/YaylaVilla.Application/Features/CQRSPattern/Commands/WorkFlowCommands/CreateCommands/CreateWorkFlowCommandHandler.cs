using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.CreateCommands
{
    internal class CreateWorkFlowCommandHandler : IRequestHandler<CreateWorkFlowCommandRequest, CreateWorkFlowCommandResponse>
    {
        private readonly IWorkFlowWriteRepository _workFlowWriteRepository;
        private readonly IMapper _mapper;

        public CreateWorkFlowCommandHandler(IWorkFlowWriteRepository workFlowWriteRepository, IMapper mapper)
        {
            _workFlowWriteRepository = workFlowWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateWorkFlowCommandResponse> Handle(CreateWorkFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<WorkFlow>(request);
            await _workFlowWriteRepository.CreateAsync(mapper);
            await _workFlowWriteRepository.SaveChangesAsync();
            return new()
            {
                IsStatus = true,
                StatusMessage = ["Oluşturma işlemi başarılı."]
            };
        }
    }
}
