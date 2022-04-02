using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Template.Auth.Services;

namespace Anotai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(UserViewModel userViewModel)
        {
            return Ok(_userService.Post(userViewModel));
        }

        [HttpPut]
        public IActionResult Put(UserViewModel userViewModel)
        {
            return Ok(_userService.Put(userViewModel));
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            string _userId = TokenService.GetValueFromClaim(HttpContext.User.Identity, ClaimTypes.NameIdentifier);
            return Ok(_userService.Delete(int.Parse(_userId)));
        }

        [HttpPost("authenticate"), AllowAnonymous]
        public IActionResult Authenticate(UserAuthenticateRequestViewModel userViewModel)
        {
            return Ok(_userService.Authenticate(userViewModel));
        }
    }
}
