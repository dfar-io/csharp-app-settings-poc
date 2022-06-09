using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CSharpAppSettingsPOC.Controllers
{
    [ApiController]
    [Route("/")]
    public class ApiController : Controller
    {
        private readonly AppSettings _appSettings;

        public ApiController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public IActionResult Get()
        {
            return Ok($"{_appSettings.Key1} {_appSettings.Key2}");
        }
    }
}