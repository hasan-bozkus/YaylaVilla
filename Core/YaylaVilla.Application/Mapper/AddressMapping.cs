using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap<Address, CreateAddressCommandRequest>().ReverseMap();
            CreateMap<Address, UpdateAddressCommandRequest>().ReverseMap();
            CreateMap<Address, GetAddressQueryResponse>().ReverseMap();
            CreateMap<Address, ResultAddressListQueryResponse>().ReverseMap();
        }
    }
}
