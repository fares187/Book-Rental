using PeacockBook.web.Controllers;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeacockBook.web.Core.Models
{
    public class BookCategory
    {
        public int BookId { get; set; }
        
        public Book? Book { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
