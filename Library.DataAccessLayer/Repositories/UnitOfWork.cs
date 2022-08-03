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
        private readonly LibraryEntities _applicationContext = new LibraryEntities ();
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;
        public UnitOfWork(
            
            IAuthorRepository authorRepository,
           IBookRepository bookRepository
            )
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
        }

        public IAuthorRepository Author
        {
            get { return _authorRepository; }
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
