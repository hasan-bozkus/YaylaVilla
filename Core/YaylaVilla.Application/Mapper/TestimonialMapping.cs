using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, CreateTestimonialCommandRequest>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommandRequest>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialQueryResponse>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialListQueryResponse>().ReverseMap();
        }
    }
}
