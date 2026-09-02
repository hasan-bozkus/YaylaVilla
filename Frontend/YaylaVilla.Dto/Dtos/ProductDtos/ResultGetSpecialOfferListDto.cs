using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaylaVilla.Dto.Dtos.ProductDtos
{
    public class ResultGetSpecialOfferListDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal PropertyPrice { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int BedRoomCount { get; set; }
        public int BathRoomCount { get; set; }
        public string AreaSquareMeter { get; set; }
        public string ImageUrl { get; set; }
    }
}
