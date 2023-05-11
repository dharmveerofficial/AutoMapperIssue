using AutoMapper;
using AutoMapperIssue.DTOs;
using AutoMapperIssue.IServices;
using AutoMapperIssue.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperIssue.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppSettingsController : ControllerBase
    {
        private readonly IAppSettingServices _appSettings;


        public AppSettingsController(IAppSettingServices appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpGet]
        public ActionResult<List<AppSettingsDto>> GetSettings()
        {           
            var settings = _appSettings.GetAppSettings();
            return new JsonResult(settings);
        }
    }
}
