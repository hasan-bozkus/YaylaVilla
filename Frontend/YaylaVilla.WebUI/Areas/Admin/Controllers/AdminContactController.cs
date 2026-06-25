using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.ContactDtos;
using YaylaVilla.WebUI.Services.ContactServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminContactController : Controller
    {
        private readonly IContactService _ContactService;

        public AdminContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _ContactService.ContactListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            await _ContactService.CreateContactAsync(createContactDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            var values = await _ContactService.DeleteContactAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _ContactService.GetContactAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(ResultGetContactByIDDto resultGetContactByIDDto)
        {
            await _ContactService.UpdateContactAsync(resultGetContactByIDDto);
            return RedirectToAction("Index");
        }
    }
}
