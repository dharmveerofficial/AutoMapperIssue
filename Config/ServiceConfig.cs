using AutoMapper;
using AutoMapperIssue.IServices;
using AutoMapperIssue.Services;
using System.Reflection;

namespace AutoMapperIssue.Config
{
    public static class ServiceConfig
    {
        public static IServiceCollection AddConfig(this IServiceCollection Services) =>
            Services.AddAutoMapper(Assembly.GetExecutingAssembly()).AddScoped<IAppSettingServices, AppSettingServices>();
    }
}
