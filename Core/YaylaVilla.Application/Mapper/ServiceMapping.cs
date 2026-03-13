using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class ServiceMapping : Profile
    {
        public ServiceMapping()
        {
            CreateMap<Service, CreateServiceCommandRequest>().ReverseMap();
            CreateMap<Service, UpdateServiceCommandRequest>().ReverseMap();
            CreateMap<Service, GetServiceQueryResponse>().ReverseMap();
            CreateMap<Service, ResultServiceListQueryResponse>().ReverseMap();
        }
    }
}
