using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.UpdateCommands;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class WorkFlowMapping : Profile
    {
        public WorkFlowMapping()
        {
            CreateMap<WorkFlow, CreateWorkFlowCommandRequest>().ReverseMap();
            CreateMap<WorkFlow, UpdateWorkFlowCommandRequest>().ReverseMap();
            //CreateMap<WorkFlow, GetWorkFlowQueryResponse>().ReverseMap();
            //CreateMap<WorkFlow, ResultWorkFlowListQueryResponse>().ReverseMap();
        }
    }
}
