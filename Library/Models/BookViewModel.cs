using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public AuthorViewModel Author { get; set; }
    }
}