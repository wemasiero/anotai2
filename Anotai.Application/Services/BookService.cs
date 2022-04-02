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

        public List<BookViewModel> Get()
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.Get();
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

        public List<BookViewModel> GetByUserId(int userId)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByUserId(userId);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByGenderId(int genderId)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByGenderId(genderId);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByGenderIdUserId(int genderId, int userId)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByGenderIdUserId(genderId, userId);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByUserIdBookTitle(int userId, string bookTitle)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByUserIdBookTitle(userId, bookTitle);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByUserIdBookDescription(int userId, string bookDescription)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByUserIdBookDescription(userId, bookDescription);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByUserIdBookAuthor(int userId, string bookAuthor)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByUserIdBookAuthor(userId, bookAuthor);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByUserIdBookISBN(int userId, string bookISBN)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByUserIdBookISBN(userId, bookISBN);
            _bookViewModel = _mapper.Map<List<BookViewModel>>(_books);
            return _bookViewModel;
        }

        public List<BookViewModel> GetByUserIdGenderDescription(int userId, string genderDescription)
        {
            List<BookViewModel> _bookViewModel = new List<BookViewModel>();
            IEnumerable<Book> _books = _bookRepository.GetByUserIdGenderDescription(userId, genderDescription);
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
