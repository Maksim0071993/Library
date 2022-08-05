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
    public class UserProfileService : IUserProfileService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }
        public int AddUser(UserProfileModel user)
        {
            var userModel = _mapper.Map<Library.DataAccessLayer.UserProfile>(user);
            _unitOfWork.UserProfile.Add(userModel);
            _unitOfWork.Save();
            return userModel.Id;
        }

        public List<UserProfileModel> GetAllUserProfiles()
        {
            var bookModels = _unitOfWork.UserProfile.GetAll().ToList();
            var result = bookModels.Select(p => _mapper.Map<UserProfileModel>(p)).ToList();
            return result;
        }
        public UserProfileModel GetById(int id)
        {
            var book = _unitOfWork.UserProfile.GetUserById(id);
            if (book != null)
                return _mapper.Map<UserProfileModel>(book);
            else
                return null;
        }
        public UserProfileModel SearchUser(string email, string password)
        {
            var user = _unitOfWork.UserProfile.Get(x => x.Email == email && x.UserPassword == password).FirstOrDefault();
            UserProfileModel result = null;
            if(user != null)
            {
                result = _mapper.Map<UserProfileModel>(user);
            }

            return result;
        }
    }
}
