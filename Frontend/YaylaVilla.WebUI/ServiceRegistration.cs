using YaylaVilla.WebUI.Services.CategoryServices;
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


        }
    }
}
