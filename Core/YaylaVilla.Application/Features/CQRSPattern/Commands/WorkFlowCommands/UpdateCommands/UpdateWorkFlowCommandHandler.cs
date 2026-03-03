using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.UpdateCommands
{
    internal class UpdateWorkFlowCommandHandler : IRequestHandler<UpdateWorkFlowCommandRequest, UpdateWorkFlowCommandResponse>
    {
        private readonly IWorkFlowWriteRepository _workFlowWriteRepository;
        private readonly IMapper _mapper;

        public UpdateWorkFlowCommandHandler(IWorkFlowWriteRepository workFlowWriteRepository, IMapper mapper)
        {
            _workFlowWriteRepository = workFlowWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateWorkFlowCommandResponse> Handle(UpdateWorkFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var mapper = _mapper.Map<WorkFlow>(request);
            await _workFlowWriteRepository.UpdateAsync(mapper);
            await _workFlowWriteRepository.SaveChangesAsync();

            return new()
            { 
                IsStatus = true,
                StatusMessage = ["Güncelleme işlemi başarılı"]
            };
        }
    }
}
