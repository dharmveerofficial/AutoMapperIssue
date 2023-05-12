using AutoMapper;
using AutoMapperIssue.DTOs;
using AutoMapperIssue.Models;

namespace AutoMapperIssue.Config
{
    public class DTOMapper : Profile
    {
        public DTOMapper()
        {
            CreateMap<AppSettings, AppSettingsDto>();
        }
    }
}
