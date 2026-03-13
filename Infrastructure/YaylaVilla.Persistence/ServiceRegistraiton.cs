using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AboutRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.AddressRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.BlogRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CategoryRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.CommentRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ContactRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ProductRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.ServiceRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TagCloudRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TestimonialRepositories;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.WorkFlowRepositories;
using YaylaVilla.Persistence.Concrete;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.AboutRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.AddressRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.BlogRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.CategoryRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.CommentRepositiories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ContactRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ProductRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.ServiceRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.TagCloudRepositories;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.TestimonialRepositroies;
using YaylaVilla.Persistence.RepositoryPattern.EntityFramework.WorkFlowRepositories;
using YaylaVilla.Persistence.Settings;

namespace YaylaVilla.Persistence
{
    public static class ServiceRegistraiton
    {
        public static void AddPersisitenceServices(this IServiceCollection services)
        {
            services.AddDbContext<YaylaVillaContext>(opt => opt.UseNpgsql(DatabaseSettings.ConnectionString), ServiceLifetime.Scoped);

            services.AddScoped<IAboutReadRepository, EFAboutReadRepository>();
            services.AddScoped<IAboutWriteRepository, EFAboutWriteRepository>();

            services.AddScoped<IAddressReadRepository, EFAddressReadRepository>();
            services.AddScoped<IAddressWriteRepository, EFAddressWriteRepository>();

            services.AddScoped<IBlogReadRepository, EFBlogReadRepository>();
            services.AddScoped<IBlogWriteRepository, EFBlogWriteRepository>();

            services.AddScoped<ICategoryReadRepository, EFCategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, EFCategoryWriteRepository>();

            services.AddScoped<ICommentReadRepository, EFCommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, EFCommentWriteRepository>();

            services.AddScoped<IContactReadRepository, EFContactReadRepository>();
            services.AddScoped<IContactWriteRepository, EFContactWriteRepository>();

            services.AddScoped<IProductReadRepository, EFProductReadRepository>();
            services.AddScoped<IProductWriteRepository, EFProductWriteRepository>();

            services.AddScoped<IServiceReadRepository, EFServiceReadRepository>();
            services.AddScoped<IServiceWriteRepository, EFServiceWriteRepository>();

            services.AddScoped<ITagCloudReadRepository, EFTagCloudReadRepository>();
            services.AddScoped<ITagCloudWriteRepository, EFTagCloudWriteRepository>();

            services.AddScoped<ITestimonialReadRepository, EFTestimonialReadRepository>();
            services.AddScoped<ITestimonialWriteRepository, EFTestimonialWriteRepository>();

            services.AddScoped<IWorkFlowReadRepository, EFWorkFlowReadRepository>();
            services.AddScoped<IWorkFlowWriteRepository, EFWorkFlowWriteRepository>();
        }
    }
}
