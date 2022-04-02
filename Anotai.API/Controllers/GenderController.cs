using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anotai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
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
     
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_genderService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(GenderViewModel genderViewModel)
        {
            return Ok(_genderService.Post(genderViewModel));
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
