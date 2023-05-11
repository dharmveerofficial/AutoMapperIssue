using AutoMapperIssue.DTOs;

namespace AutoMapperIssue.IServices
{
    public interface IAppSettingServices
    {
        IEnumerable<AppSettingsDto> GetAppSettings();
    }
}
