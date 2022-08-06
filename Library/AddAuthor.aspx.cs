using AutoMapper;
using Library.BusinessLogicLayer.Interfaces;
using Library.BusinessLogicLayer.Models;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Xunit.Sdk;

namespace Library
{
    public partial class AddAuthor : System.Web.UI.Page
    {
        public IAuthorService AuthorService { get; set; }
        private readonly IMapper _mapper;
        public AddAuthor(IAuthorService authorService)
        {
            AuthorService = authorService;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }

        protected void AddNewAuthor(object sender, EventArgs e)
        {
            AuthorViewModel authorModel = new AuthorViewModel();
            authorModel.FirstName = FirstName.Text;
            authorModel.LastName = LastName.Text;
            var resultSearch = AuthorService.IsThereAnAuthor(authorModel.FirstName, authorModel.LastName);
            if (IsPostBack)
            {
                if(resultSearch == 0)
                {
                    var newAuthor = AuthorService.AddAuthor(_mapper.Map<AuthorModel>(authorModel));
                    Session["AuthorId"] = newAuthor;
                    Response.Redirect("AddBook");
                }
                else
                {
                    var author = AuthorService.IsThereAnAuthor(FirstName.Text, LastName.Text);
                    Session["AuthorId"] = author;
                    Response.Redirect("AddBook");
                }
                
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}