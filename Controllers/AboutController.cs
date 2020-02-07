using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace PubDev.Globalization.API.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class AboutController : ControllerBase
    {
        private readonly IStringLocalizer<AboutController> _localizer;

        public AboutController(IStringLocalizer<AboutController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public string Get()
        {
            return _localizer["About_Title"];
        }
    }
}