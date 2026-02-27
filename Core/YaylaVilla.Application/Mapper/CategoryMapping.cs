using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.CreateCommands;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CreateCategoryCommandRequest>().ReverseMap();
        }
    }
}
