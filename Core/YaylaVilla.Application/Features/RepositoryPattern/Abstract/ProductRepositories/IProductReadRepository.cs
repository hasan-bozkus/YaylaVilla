using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetProductSpecialOfferListQueries;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories
{
    public interface IProductReadRepository : IGenericReadRepository<Product>
    {
        Task<List<GetProductSpecialOfferListQueryResponse>> GetProductSpecialOfferListAsync();
    }
}
