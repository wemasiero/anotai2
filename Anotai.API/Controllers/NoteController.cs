using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anotai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_noteService.Get());
        }

        [HttpGet("{id:int}/GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_noteService.GetById(id));
        }

        [HttpGet("{bookId:int}/GetByBookId")]
        public IActionResult GetByBookId(int bookId)
        {
            return Ok(_noteService.GetByBookId(bookId));
        }

        [HttpGet("{userId:int}/GetByUserId")]
        public IActionResult GetByUserId(int userId)
        {
            return Ok(_noteService.GetByUserId(userId));
        }

        [HttpGet("{genderId:int}/GetByGenderId")]
        public IActionResult GetByGenderId(int userId, int genderId)
        {
            return Ok(_noteService.GetByGenderId(userId, genderId));
        }

        [HttpGet("{userId:int}/GetByAnnotation{annotation}")]
        public IActionResult GetByAnnotation(int userId, string annotation)
        {
            return Ok(_noteService.GetByAnnotation(userId, annotation));
        }

        [HttpGet("{userId:int}/GetByBookAuthor{bookAuthor}")]
        public IActionResult GetByBookAuthor(int userId, string bookAuthor)
        {
            return Ok(_noteService.GetByBookAuthor(userId, bookAuthor));
        }

        [HttpGet("{userId:int}/GetByBookDescription{bookDescription}")]
        public IActionResult GetByBookDescription(int userId, string bookDescription)
        {
            return Ok(_noteService.GetByBookDescription(userId, bookDescription));
        }

        [HttpGet("{userId:int}/GetByBookTitle{bookTitle}")]
        public IActionResult GetByBookTitle(int userId, string bookTitle)
        {
            return Ok(_noteService.GetByBookTitle(userId, bookTitle));
        }

        [HttpPost]
        public IActionResult Post(NoteViewModel noteViewModel)
        {
            return Ok(_noteService.Post(noteViewModel));
        }

        [HttpPut]
        public IActionResult Put(NoteViewModel noteViewModel)
        {
            return Ok(_noteService.Put(noteViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_noteService.Delete(id));
        }

    }
}
