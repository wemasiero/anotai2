using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using AutoMapper;

namespace Anotai.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public List<BookViewModel> GetAll()
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetAll();
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetById(int id)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetById(id);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public bool Post(BookViewModel bookViewModel)
        {
            Book _book= _mapper.Map<Book>(bookViewModel);
            _bookRepository.Create(_book);

            return true;
        }

        public bool Put(BookViewModel bookViewModel)
        {
            Book _book = _bookRepository.Find(x => x.Id == bookViewModel.Id && !x.IsDeleted);

            if (_book == null)
                throw new Exception("Not Found!");

            _book = _mapper.Map<Book>(bookViewModel);
            _bookRepository.Update(_book);

            return true;
        }

        public bool Delete(int id)
        {
            Book _book = _bookRepository.Find(x => x.Id == id && !x.IsDeleted);

            if (_book == null)
                throw new Exception("Not Found!");

            return _bookRepository.Delete(_book);
        }
    }
}
