using Library.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLayer.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly LibraryEntity _applicationContext;
        public UserProfileRepository(LibraryEntity applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public List<UserProfile> Get(Func<UserProfile, bool> func)
        {
            var users = _applicationContext.UserProfile.Where(func).ToList();
            return users;
        }

        public void Add(UserProfile userProfile)
        {
            _applicationContext.UserProfile.Add(userProfile);
        }

        public List<UserProfile> GetAll()
        {
            var allUsers = _applicationContext.UserProfile.ToList();
            return allUsers;
        }
        public UserProfile GetUserById(int id)
        {
            var user = _applicationContext.UserProfile.Where(x => x.Id == id).FirstOrDefault();

            return user;
        }
    }
}
