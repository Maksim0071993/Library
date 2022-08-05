using Library.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryEntity _applicationContext;
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        public UnitOfWork(
            LibraryEntity libraryContext,
            IAuthorRepository authorRepository,
           IBookRepository bookRepository,
           IUserProfileRepository userProfileRepository
            )
        {
            _applicationContext = libraryContext;
            _authorRepository = new AuthorRepository(_applicationContext);
            _bookRepository = new BookRepository(_applicationContext);
            _userProfileRepository = new UserProfileRepository(_applicationContext);
        }

        public IAuthorRepository Author
        {
            get { return _authorRepository; }
        }
        public IUserProfileRepository UserProfile
        {
            get { return _userProfileRepository; }
        }

        public IBookRepository Book
        {
            get { return _bookRepository; }
        }
        public void Save()
        {
            _applicationContext.SaveChanges();
        }
    }
}
