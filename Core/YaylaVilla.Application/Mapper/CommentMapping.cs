using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.ListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Mapper
{
    public class CommentMapping : Profile
    {
        public CommentMapping()
        {
            CreateMap<Comment, CreateCommentCommandRequest>().ReverseMap();
            CreateMap<Comment, UpdateCommentCommandRequest>().ReverseMap();
            CreateMap<Comment, GetCommentQueryResponse>().ReverseMap();
            CreateMap<Comment, ResultCommentListQueryResponse>().ReverseMap();
        }
    }
}
