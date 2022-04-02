using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anotai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.Get());
        }

        [HttpGet("{id:int}/GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_bookService.GetById(id));
        }

        [HttpGet("{userId:int}/GetByUserId")]
        public IActionResult GetByUserId(int userId)
        {
            return Ok(_bookService.GetByUserId(userId));
        }

        [HttpGet("{genderId:int}/GetByGenderId")]
        public IActionResult GetByGenderId(int genderId)
        {
            return Ok(_bookService.GetByGenderId(genderId));
        }

        [HttpGet("{genderId:int}/GetByGenderIdUserId{userId:int}")]
        public IActionResult GetByGenderIdUserId(int genderId, int userId)
        {
            return Ok(_bookService.GetByGenderIdUserId(genderId, userId));
        }

        [HttpGet("{userId:int}/GetByUserIdBookTitle{bookTitle}")]
        public IActionResult GetByUserIdBookTitle(int userId, string bookTitle)
        {
            return Ok(_bookService.GetByUserIdBookTitle(userId, bookTitle));
        }

        [HttpGet("{userId:int}/GetByUserIdBookDescription{bookDescription}")]
        public IActionResult GetByUserIdBookDescription(int userId, string bookDescription)
        {
            return Ok(_bookService.GetByUserIdBookDescription(userId, bookDescription));
        }

        [HttpGet("{userId:int}/GetByUserIdBookAuthor{bookAuthor}")]
        public IActionResult GetByUserIdBookAuthor(int userId, string bookAuthor)
        {
            return Ok(_bookService.GetByUserIdBookAuthor(userId, bookAuthor));
        }

        [HttpGet("{userId:int}/GetByUserIdBookISBN{bookISBN}")]
        public IActionResult GetByUserIdBookISBN(int userId, string bookISBN)
        {
            return Ok(_bookService.GetByUserIdBookISBN(userId, bookISBN));
        }

        [HttpGet("{userId:int}/GetByUserIdGenderDescription{genderDescription}")]
        public IActionResult GetByUserIdGenderDescription(int userId, string genderDescription)
        {
            return Ok(_bookService.GetByUserIdGenderDescription(userId, genderDescription));
        }

        [HttpPost]
        public IActionResult Post(BookViewModel bookViewModel)
        {
            return Ok(_bookService.Post(bookViewModel));
        }

        [HttpPut]
        public IActionResult Put(BookViewModel bookViewModel)
        {
            return Ok(_bookService.Put(bookViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_bookService.Delete(id));
        }
    }
}
