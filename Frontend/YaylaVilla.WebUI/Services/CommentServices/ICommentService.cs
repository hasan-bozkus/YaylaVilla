using YaylaVilla.Dto.Dtos.CommentDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.CommentServices
{
    public interface ICommentService
    {
        Task<List<ResultCommentDto>> CommentListAsync();
        Task<ResultServiceResponseViewModel> CreateCommentAsync(CreateCommentDto createCommentDto);
        Task<ResultServiceResponseViewModel> DeleteCommentAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateCommentAsync(ResultGetCommentByIDDto resultGetCommentByIDDto);
        Task<ResultGetCommentByIDDto> GetCommentAsync(int id);
    }
}