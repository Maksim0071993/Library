using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Interfaces
{
    public interface IBookRepository
    {
        List<Book> Get(Func<Book, bool> func);
        void Add(Book book);
        List<Book> GetAll();
        Book GetBookById(int id);
        IQueryable<Book> GetSomeBooks();
    }
}
