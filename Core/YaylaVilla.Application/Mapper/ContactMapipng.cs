using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class ContactMapipng : Profile
    {
        public ContactMapipng()
        {
            CreateMap<Contact, CreateContactCommandRequest>().ReverseMap();
            CreateMap<Contact, UpdateContactCommandRequest>().ReverseMap();
            CreateMap<Contact, GetContactQueryResponse>().ReverseMap();
            CreateMap<Contact, ResultContactListQueryResponse>().ReverseMap();
        }
    }
}
