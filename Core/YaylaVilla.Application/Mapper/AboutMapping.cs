using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.UpdateCommands;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, CreateAboutCommandRequest>().ReverseMap();
            CreateMap<About, UpdateAboutCommandRequest>().ReverseMap();
            //CreateMap<About, GetAboutQueryResponse>().ReverseMap();
            //CreateMap<About, ResultAboutListQueryResponse>().ReverseMap();
        }
    }
}
