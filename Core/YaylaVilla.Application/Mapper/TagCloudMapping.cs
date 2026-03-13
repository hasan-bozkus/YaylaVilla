using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class TagCloudMapping : Profile
    {
        public TagCloudMapping()
        {
            CreateMap<TagCloud, CreateTagCloudCommandRequest>().ReverseMap();
            CreateMap<TagCloud, UpdateTagCloudCommandRequest>().ReverseMap();
            CreateMap<TagCloud, GetTagCloudQueryResponse>().ReverseMap();
            CreateMap<TagCloud, ResultTagCloudListQueryResponse>().ReverseMap();
        }
    }
}
