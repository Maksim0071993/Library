using Library.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.Interfaces
{
    public interface IBookService
    {
        List<BookModel> GetAllBooks();
        BookModel GetById(int id);
        int AddBook(BookModel book);
        List<BookModel> GetFilterBooks(string lastName, string nameOfBook);
    }
}
