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
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }

        public int AddAuthor(AuthorModel author)
        {
            var authorModel = _mapper.Map<Library.DataAccessLayer.Author>(author);
            _unitOfWork.Author.Add(authorModel);
            _unitOfWork.Save();
            return authorModel.Id;
        }

        public List<AuthorModel> GetAllAuthors()
        {
            var authorModels = _unitOfWork.Author.GetAll().ToList();
            var result = authorModels.Select(p => _mapper.Map<AuthorModel>(p)).ToList();
            return result;
        }
        public AuthorModel GetAuthorById(int id)
        {
            var author = _unitOfWork.Author.GetAuthorById(id);
            if (author != null)
                return _mapper.Map<AuthorModel>(author);
            else
                return null;
        }
    }
}
