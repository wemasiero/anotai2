using Anotai.Application.Interfaces;
using Anotai.Application.ViewModels;
using Anotai.Domain.Entities;
using Anotai.Domain.Interfaces;
using AutoMapper;

namespace Anotai.Application.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;

        public NoteService(INoteRepository noteRepository, IMapper mapper)
        {
            _noteRepository = noteRepository;
            _mapper = mapper;
        }

        public List<NoteViewModel> Get()
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.Get();
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetById(int id)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetById(id);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByBookId(int bookId)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByBookId(bookId);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByUserId(int userId)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByUserId(userId);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByGenderId(int userId, int genderId)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByGenderId(userId, genderId);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByAnnotation(int userId, string annotation)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByAnnotation(userId, annotation);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByBookAuthor(int userId, string bookAuthor)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByBookAuthor(userId, bookAuthor);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByBookDescription(int userId, string bookDescription)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByBookDescription(userId, bookDescription);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public List<NoteViewModel> GetByBookTitle(int userId, string bookTitle)
        {
            List<NoteViewModel> _noteViewModel = new List<NoteViewModel>();
            IEnumerable<Note> _notes = _noteRepository.GetByBookTitle(userId, bookTitle);
            _noteViewModel = _mapper.Map<List<NoteViewModel>>(_notes);
            return _noteViewModel;
        }

        public bool Post(NoteViewModel noteViewModel)
        {
            Note _note = _mapper.Map<Note>(noteViewModel);
            _noteRepository.Create(_note);

            return true;
        }

        public bool Put(NoteViewModel noteViewModel)
        {
            Note _note = _noteRepository.Find(x => x.Id == noteViewModel.Id && !x.IsDeleted);

            if (_note == null)
                throw new Exception("Not Found!");

            _note = _mapper.Map<Note>(noteViewModel);
            _noteRepository.Update(_note);

            return true;
        }

        public bool Delete(int id)
        {
            Note _note = _noteRepository.Find(x => x.Id == id && !x.IsDeleted);

            if (_note == null)
                throw new Exception("Not Found!");

            return _noteRepository.Delete(_note);
        }
    }
}
