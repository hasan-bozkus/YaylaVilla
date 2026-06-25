using YaylaVilla.Dto.Dtos.ContactDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> ContactListAsync();
        Task<ResultServiceResponseViewModel> CreateContactAsync(CreateContactDto createContactDto);
        Task<ResultServiceResponseViewModel> DeleteContactAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateContactAsync(ResultGetContactByIDDto resultGetContactByIDDto);
        Task<ResultGetContactByIDDto> GetContactAsync(int id);
    }
}
