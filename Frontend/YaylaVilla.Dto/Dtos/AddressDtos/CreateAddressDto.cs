using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaylaVilla.Dto.Dtos.AddressDtos
{
    public class CreateAddressDto
    {
        public string MapLocation { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
