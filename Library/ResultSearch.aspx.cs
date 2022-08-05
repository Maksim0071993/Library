using Library.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class ResultSearch : System.Web.UI.Page
    {
        public IBookService BookService { get; set; }
        public ResultSearch(IBookService bookService)
        {
            BookService = bookService;
        }
        protected string GetFilterBooks()
        {
            StringBuilder html = new StringBuilder();
            var resultSearch = BookService.GetFilterBooks(Session["LastName"].ToString(), Session["BookName"].ToString());
            if (resultSearch != null)
            {

                foreach (var book in resultSearch)
                {
                    html.Append(String.Format("<tr><td>{0} {1}</td><td>{2}</td>",
                         book.Author.FirstName, book.Author.LastName, book.BookName));
                }
            }
            return html.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}