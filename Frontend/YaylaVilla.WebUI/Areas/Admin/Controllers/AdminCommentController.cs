using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.CommentServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        private readonly ICommentService _commentService;

        public AdminCommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _commentService.CommentListAsync();
            return View(values);
        }

        public async Task<IActionResult> DeleteComment(int id)
        {
            var values = await _commentService.DeleteCommentAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> GetComment(int id)
        {
            var value = await _commentService.GetCommentAsync(id);
            return View(value);
        }
    }
}
