using AutoMapper;
using Library.BusinessLogicLayer.Models;
using Library.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookModel, Book>().ReverseMap();
            CreateMap<AuthorModel, Author>().ReverseMap();
        }
    }
}
