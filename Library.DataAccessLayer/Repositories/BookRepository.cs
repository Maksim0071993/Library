using Library.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryEntities _applicationContext;
        public BookRepository(LibraryEntities applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public List<Book> Get(Func<Book, bool> func)
        {
            var books = _applicationContext.Book.Where(func).ToList();
            return books;
        }

        public void Add(Book book)
        {
            _applicationContext.Book.Add(book);
        }
        public IQueryable<Book> GetSomeBooks()
        {
            var books = _applicationContext.Book.AsQueryable();
            return books;
        }
        public List<Book> GetAll()
        {
            var allBooks = _applicationContext.Book.ToList();
            return allBooks;
        }
        public Book GetBookById(int id)
        {
            var book = _applicationContext.Book.Where(x => x.Id == id).FirstOrDefault();

            return book;
        }
    }
}
