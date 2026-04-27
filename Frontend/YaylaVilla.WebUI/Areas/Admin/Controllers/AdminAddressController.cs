using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.AddressDtos;
using YaylaVilla.WebUI.Services.AddressServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AdminAddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _addressService.AddressListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAddress()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressDto createAddressDto)
        {
            await _addressService.CreateAddressAsync(createAddressDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAddress(int id)
        {
            var values = await _addressService.DeleteAddressAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }



        [HttpGet]
        public async Task<IActionResult> UpdateAddress(int id)
        {
            var value = await _addressService.GetAddressAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAddress(ResultGetAddressByIDDto resultGetAddressByIDDto)
        {
            await _addressService.UpdateAddressAsync(resultGetAddressByIDDto);
            return RedirectToAction("Index");
        }
    }
}
