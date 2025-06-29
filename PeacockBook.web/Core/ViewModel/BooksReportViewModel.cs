using PeacockBook.web.Core.Models;
using PeacockBook.web.Core.Utilites;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PeacockBook.web.Core.ViewModel
{
    public class BooksReportViewModel
    {
        [Display(Name = "Authors")]
        public List<int>? SelectedAuthors { get; set; }  = new List<int>();  
        public IEnumerable<SelectListItem> Author { get; set; }=new List<SelectListItem>();

        [Display(Name = "Categories")]
        public List<int>? SelectedCategories { get; set; } = new List<int>();
        public IEnumerable<SelectListItem> Categories { get; set; }=new List<SelectListItem>(); 
        public PaginatedList<Book> Data { get; set; }  
    }
}
