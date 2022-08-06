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
        private readonly IMapper _mapper;

        public AddBook(IBookService bookService)
        {
            BookService = bookService;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }
        protected void AddNewBook(object sender, EventArgs e)
        {
            BookViewModel model = new BookViewModel();
            model.AuthorId = int.Parse(Session["AuthorId"].ToString());
            model.BookName = AddedBookName.Text;
            if (IsPostBack)
            { 
                BookService.AddBook(_mapper.Map<BookModel>(model));
                Response.Redirect("BookAdditionConfirmation");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}