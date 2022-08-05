using Library.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.Interfaces
{
    public interface IUserProfileService
    {
        int AddUser(UserProfileModel user);
        List<UserProfileModel> GetAllUserProfiles();
        UserProfileModel GetById(int id);
        UserProfileModel SearchUser(string email, string password);
    }
}
