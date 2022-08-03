using AutoMapper;
using Library.BusinessLogicLayer.Interfaces;
using Library.BusinessLogicLayer.Models;
using Library.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }
        public int AddBook(BookModel book)
        {
            var bookModel = _mapper.Map<Library.DataAccessLayer.Book>(book);
            _unitOfWork.Book.Add(bookModel);
            _unitOfWork.Save();
            return bookModel.Id;
        }

        public List<BookModel> GetAllBooks()
        {
            var bookModels = _unitOfWork.Book.GetAll().ToList();
            var result = bookModels.Select(p => _mapper.Map<BookModel>(p)).ToList();
            return result;
        }
        public BookModel GetById(int id)
        {
            var book = _unitOfWork.Book.GetBookById(id);
            if (book != null)
                return _mapper.Map<BookModel>(book);
            else
                return null;
        }
        public List<BookModel> GetFilterBooks(string lastName,string nameOfBook)
        {
            var allBooks = _unitOfWork.Book.GetSomeBooks();

            if (nameOfBook != null)
            {
                allBooks = allBooks.Where(p => p.BookName.Contains(nameOfBook));
            }
            if (lastName != null)
            {
                 allBooks = allBooks.Where(p => p.Author.LastName.Contains(lastName) /*== lastName*/);
            }
            var result = allBooks.Select(x => _mapper.Map<BookModel>(x)).ToList();
            return result;
        }
    }
}
