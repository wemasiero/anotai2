using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anotai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBooksById(int id)
        {
            return Ok(_bookService.GetById(id));
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
