using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anotai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IGenderService _genderService;

        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_genderService.Get());
        }

        [HttpPost]
        /*
        public IActionResult Post(GenderViewModel genderViewModel)
        {
            return Ok(_genderService.Post());
        }
        */
    }
}
