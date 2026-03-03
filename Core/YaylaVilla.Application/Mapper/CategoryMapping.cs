using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CreateCategoryCommandRequest>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommandRequest>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResponse>().ReverseMap();
            CreateMap<Category, ResultCategoryListQueryResponse>().ReverseMap();
        }
    }
}
