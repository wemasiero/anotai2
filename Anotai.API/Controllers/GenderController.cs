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
        public IActionResult GetAll()
        {
            return Ok(_genderService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(GenderViewModel genderViewModel)
        {
            return Ok(_genderService.Post(genderViewModel));
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_genderService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(GenderViewModel genderViewModel)
        {
            return Ok(_genderService.Put(genderViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_genderService.Delete(id));
        }

    }
}
