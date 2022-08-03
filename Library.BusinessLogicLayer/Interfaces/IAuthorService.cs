using Library.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.Interfaces
{
    public interface IAuthorService
    {
        int AddAuthor(AuthorModel author);
        List<AuthorModel> GetAllAuthors();
        AuthorModel GetAuthorById(int id);
    }
}
