using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.RepositoryPattern.Abstract.CommentRepositories
{
    public interface ICommentWriteRepository : IGenericWriteRepository<Comment>
    {
    }
}
