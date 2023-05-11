using AutoMapper;
using AutoMapperIssue.DTOs;
using AutoMapperIssue.IServices;
using AutoMapperIssue.Models;

namespace AutoMapperIssue.Services
{
    public class AppSettingServices:IAppSettingServices
    {
        private static List<AppSettings> app1 = new List<AppSettings>()
        {
            new AppSettings
            {
                Name = "app",
            Email = "email",
            PhoneNumber = "1234567890",
            },
            new AppSettings
            {
                Name = "app1",
            Email = "email1",
            PhoneNumber = "1234567891",
            }
        };

        private readonly IMapper _mapper;
        public AppSettingServices(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<AppSettingsDto> GetAppSettings()
        {
            var appSettings = new AppSettings()
            {
                Name = "app",
                Email = "email",
                PhoneNumber = "1234567890",
            };

            var _val = _mapper.Map<IEnumerable<AppSettingsDto>>(app1);
            return _val;
        }
    }
}
