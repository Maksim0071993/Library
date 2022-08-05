using Library.BusinessLogicLayer.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Search : System.Web.UI.Page
    {
        public IBookService BookService { get; set; }

        public Search(IBookService bookService)
        {
            BookService = bookService;
        }
        
        protected void SearchBook(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Session["LastName"] = LastName.Text;
                Session["BookName"] = NameOfBook.Text;
                    Response.Redirect("ResultSearch");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}