using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; }
    }
}
