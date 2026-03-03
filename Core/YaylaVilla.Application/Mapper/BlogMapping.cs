using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.UpdateCommands;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<Blog, CreateBlogCommandRequest>().ReverseMap();
            CreateMap<Blog, UpdateBlogCommandRequest>().ReverseMap();
            //CreateMap<Blog, GetBlogQueryResponse>().ReverseMap();
            //CreateMap<Blog, ResultBlogListQueryResponse>().ReverseMap();
        }
    }
}
