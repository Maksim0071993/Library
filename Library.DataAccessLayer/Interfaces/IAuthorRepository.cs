using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> Get(Func<Author, bool> func);
        void Add(Author author);
        List<Author> GetAll();
        Author GetAuthorById(int id);
    }
}
