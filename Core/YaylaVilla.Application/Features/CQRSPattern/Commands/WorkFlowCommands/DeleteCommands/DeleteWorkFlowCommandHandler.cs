using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.DeleteCommands
{
    internal class DeleteWorkFlowCommandHandler : IRequestHandler<DeleteWorkFlowCommandRequest, DeleteWorkFlowCommandResponse>
    {
        private readonly IWorkFlowReadRepository _workFlowReadRepository;
        private readonly IWorkFlowWriteRepository _workFlowWriteRepository;

        public DeleteWorkFlowCommandHandler(IWorkFlowReadRepository workFlowReadRepository, IWorkFlowWriteRepository workFlowWriteRepository)
        {
            _workFlowReadRepository = workFlowReadRepository;
            _workFlowWriteRepository = workFlowWriteRepository;
        }

        public async Task<DeleteWorkFlowCommandResponse> Handle(DeleteWorkFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _workFlowReadRepository.GetByIDAsync(request.id);
            await _workFlowWriteRepository.DeleteAsync(result);
            await _workFlowWriteRepository.SaveChangesAsync();
            return new DeleteWorkFlowCommandResponse()
            {
                IsStatus = true,
                StatusMessage = ["Silme işlemi başarılı."]
            };
            throw new NotImplementedException();
        }
    }
}
