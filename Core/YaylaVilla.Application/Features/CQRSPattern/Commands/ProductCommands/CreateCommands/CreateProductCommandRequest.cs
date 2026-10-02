using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.CreateCommands
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal PropertyPrice { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LandSquareMeter { get; set; }
        public string AreaSquareMeter { get; set; }
        public int RoomCount { get; set; }
        public int BedRoomCount { get; set; }
        public int BathRoomCount { get; set; }
        public int GarageCount { get; set; }
        public int StoreyCount { get; set; }
        public string BuildYear { get; set; }
        public string BuildingAge { get; set; }
        public string HeatingType { get; set; }
        public string KitchenType { get; set; }
        public bool SwimmingPool { get; set; }
        public bool IsFurnished { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}