using YaylaVilla.WebUI.Services.AboutServices;
using YaylaVilla.WebUI.Services.AddressServices;
using YaylaVilla.WebUI.Services.BlogServices;
using YaylaVilla.WebUI.Services.CategoryServices;
using YaylaVilla.WebUI.Services.CommentServices;
using YaylaVilla.WebUI.Services.ContactServices;
using YaylaVilla.WebUI.Services.ProductServices;
using YaylaVilla.WebUI.Services.ServiceServices;
using YaylaVilla.WebUI.Services.TagCloudServices;
using YaylaVilla.WebUI.Services.TestimonialServices;
using YaylaVilla.WebUI.Services.WorkFlowServices;
using YaylaVilla.WebUI.Settings;

namespace YaylaVilla.WebUI
{
    public static class ServiceRegistration
    {
        public static void AddWebUIServiceRouteServices(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<ServiceApiSettings>(builder.Configuration.GetSection("ServiceApiSettings"));

            var values = builder.Configuration.GetSection("ServiceApiSettings").Get<ServiceApiSettings>();

            builder.Services.AddHttpClient<ICategoryService, CategoryService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Category.Path}/");
            });

            builder.Services.AddHttpClient<IAboutServices, AboutService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.About.Path}/");
            });

            builder.Services.AddHttpClient<IAddressService, AddressService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Address.Path}/");
            });

            builder.Services.AddHttpClient<IBlogService, BlogService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Blog.Path}/");
            });

            builder.Services.AddHttpClient<ICommentService, CommentService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Comment.Path}/");
            });

            builder.Services.AddHttpClient<IContactService, ContactService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Contact.Path}/");
            });

            builder.Services.AddHttpClient<IProductService, ProductService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Product.Path}/");
            });

            builder.Services.AddHttpClient<IServiceService, ServiceService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Service.Path}/");
            });

            builder.Services.AddHttpClient<ITagCloudService, TagCloudService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.TagCloud.Path}/");
            });

            builder.Services.AddHttpClient<ITestimonialService, TestimonialService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.Testimonial.Path}/");
            });

            builder.Services.AddHttpClient<IWorkFlowService, WorkFlowService>(opt =>
            {
                opt.BaseAddress = new Uri($"{values!.ApiServerUrl}/{values.WorkFlow.Path}/");
            });
        }
    }
}
