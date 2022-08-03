using Library.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryEntities _applicationContext;
        public AuthorRepository(LibraryEntities applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public List<Author> Get(Func<Author, bool> func)
        {
            var authors = _applicationContext.Author.Where(func).ToList();
            return authors;
        }

        public void Add(Author author)
        {
            _applicationContext.Author.Add(author);
        }

        public List<Author> GetAll()
        {
            var allAuthors = _applicationContext.Author.ToList();
            return allAuthors;
        }
        public Author GetAuthorById(int id)
        {
            var author = _applicationContext.Author.Where(x => x.Id == id).FirstOrDefault();

            return author;
        }
    }
}
