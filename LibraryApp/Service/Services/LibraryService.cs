using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class LibraryService : ILibraryService

    {
        private readonly ILibraryRepository _libraryRepository;
        private int _count = 1;


        public LibraryService()
        {
            _libraryRepository = new LibraryRepository();
        }

        public void Create(Library library)
        {
            library.Id = _count;
            _libraryRepository.Create(library);
            _count++;
        }

        public List<Library> GetAll() => _libraryRepository.GetAll();

        public Library GetById(int id)
        {
            return _libraryRepository.GetById(id);
        }
    }
}
