using YaylaVilla.Dto.Dtos.AddressDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.AddressServices
{
    public interface IAddressService
    {
        Task<List<ResultAddressDto>> AddressListAsync();
        Task<ResultServiceResponseViewModel> CreateAddressAsync(CreateAddressDto createAddressDto);
        Task<ResultServiceResponseViewModel> DeleteAddressAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateAddressAsync(ResultGetAddressByIDDto resultGetAddressByIDDto);
        Task<ResultGetAddressByIDDto> GetAddressAsync(int id);
    }
}