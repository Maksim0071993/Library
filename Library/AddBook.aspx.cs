using AutoMapper;
using Library.BusinessLogicLayer.Interfaces;
using Library.BusinessLogicLayer.Models;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class AddBook : System.Web.UI.Page
    {
        public IBookService BookService { get; set; }
        public IAuthorService AuthorService {get;set;}
        private readonly IMapper _mapper;

        public AddBook(IBookService bookService, IAuthorService authorService)
        {
            BookService = bookService;
            AuthorService = authorService;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }
        protected void AddNewBook(object sender, EventArgs e)
        {
            BookViewModel model = new BookViewModel();
            model.BookName = BookName.Text;
            AuthorViewModel authorModel = new AuthorViewModel();
            authorModel.FirstName = FirstName.Text;
            authorModel.LastName = LastName.Text;
            if(IsPostBack)
            {
                var newAuthor = AuthorService.AddAuthor(_mapper.Map<AuthorModel>(authorModel));
                model.AuthorId = newAuthor;
                BookService.AddBook(_mapper.Map<BookModel>(model));
                Response.Redirect("BookAdditionConfirmation");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}