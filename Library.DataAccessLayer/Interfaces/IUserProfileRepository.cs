using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Interfaces
{
    public interface IUserProfileRepository
    {
        List<UserProfile> Get(Func<UserProfile, bool> func);
        void Add(UserProfile userProfile);
        List<UserProfile> GetAll();
        UserProfile GetUserById(int id);
    }
}
