using AutoMapper;
using AutoMapperIssue.DTOs;
using AutoMapperIssue.IServices;
using AutoMapperIssue.Models;

namespace AutoMapperIssue.Services
{
    public class AppSettingServices:IAppSettingServices
    {
        private readonly IMapper _mapper;
        public AppSettingServices(IMapper mapper)
        {
            _mapper = mapper;
        }
        public AppSettingsDto GetAppSettings()
        {
            var appSettings = new AppSettings() { 
                Name = "app",
                Email= "email",
                PhoneNumber= "1234567890",
            };
            var dto = _mapper.Map<AppSettingsDto>(appSettings);
            return dto;
        }
    }
}
