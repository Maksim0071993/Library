using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IAuthorRepository Author { get; }
        void Save();
        IBookRepository Book { get; }
        IUserProfileRepository UserProfile { get; }
    }
}
