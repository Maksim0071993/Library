using AutoMapper;
using Library.BusinessLogicLayer.Models;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookModel, BookViewModel>().ReverseMap();
            CreateMap<AuthorModel, AuthorViewModel>().ReverseMap();
            CreateMap<UserProfileModel, UserProfileViewModel>().ReverseMap();
        }
    }
}