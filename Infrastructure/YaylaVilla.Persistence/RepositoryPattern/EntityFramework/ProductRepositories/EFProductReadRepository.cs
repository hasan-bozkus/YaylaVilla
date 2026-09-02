using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetProductSpecialOfferListQueries;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories;
using YaylaVilla.Domain.Entites;
using YaylaVilla.Persistence.Concrete;

namespace YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ProductRepositories
{
    public class EFProductReadRepository : GenericReadRepository<Product>, IProductReadRepository
    {
        private readonly YaylaVillaContext _context;

        public EFProductReadRepository(YaylaVillaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<GetProductSpecialOfferListQueryResponse>> GetProductSpecialOfferListAsync()
        {
            var values = await _context.Products.Where(x => x.IsSpecialOffer == true).Take(3).Select(y => new GetProductSpecialOfferListQueryResponse
            {
                ProductID = y.ProductID,
                Title = y.Title,
                AreaSquareMeter = y.AreaSquareMeter,
                BathRoomCount = y.BathRoomCount,
                BedRoomCount = y.BedRoomCount,
                City = y.City,
                District = y.District,
                ImageUrl = y.ImageUrl,
                PropertyPrice = y.PropertyPrice
            }).ToListAsync();

            return values;
        }
    }
}
