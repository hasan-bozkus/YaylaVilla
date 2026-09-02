using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetProductSpecialOfferListQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, CreateProductCommandRequest>().ReverseMap();
            CreateMap<Product, UpdateProductCommandRequest>().ReverseMap();
            CreateMap<Product, GetProductQueryResponse>().ReverseMap();
            CreateMap<Product, ResultProductListQueryResponse>().ReverseMap();
            CreateMap<Product, GetProductSpecialOfferListQueryResponse>().ReverseMap();
        }
    }
}
