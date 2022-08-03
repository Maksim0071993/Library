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
                var resultSearch = BookService.GetFilterBooks(LastName.ToString(), NameOfBook.ToString());
                if(resultSearch != null)
                {
                    StringBuilder html = new StringBuilder();
                    var allBooks = BookService.GetAllBooks();
                    foreach (var book in allBooks)
                    {
                        html.Append(String.Format("<tr><td>{0} {1}</td><td>{2}</td>",
                             book.Author.FirstName, book.Author.LastName, book.BookName));
                    }
                     html.ToString();
                    Response.Redirect("ListBooks" + html);
                }
            }
            //var resultSearch = BookService.GetFilterBooks(LastNameAuthor.ToString(), NameOfBook.ToString());

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}