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
    public partial class AllBooks : System.Web.UI.Page
    {  
        public IBookService BookService { get; set; }
        private int pageSize = 8;
        public AllBooks(IBookService bookService)
        {
            BookService = bookService;
        }
        protected int CurrentPage
        {
            get
            {
                int page;
                return int.TryParse(Request.QueryString["page"], out page) ? page : 1;
            }
        }
        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)BookService.GetAllBooks().Count() / pageSize);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected string GetAllBooks()
        {
            StringBuilder html = new StringBuilder();
            var allBooks = BookService.GetAllBooks().OrderBy(b => b.BookName).Skip((CurrentPage - 1) * pageSize).Take(pageSize);
            foreach (var book in allBooks)
            {
                html.Append(String.Format("<tr><td>{0} {1}</td><td>{2}</td>",
                     book.Author.FirstName, book.Author.LastName,book.BookName));
            }
            return html.ToString();
        }
    }
}