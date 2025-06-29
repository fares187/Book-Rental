using PeacockBook.web.Core.Models;
using PeacockBook.web.Core.Utilites;

namespace PeacockBook.web.Core.ViewModel
{
    public class RentalsReportViewModel
    {
        public DateTime? StartDate { get; set; } 
        public DateTime? EndDate { get; set; }
        public int PageNumber { get; set; }
        public PaginatedList<RentalViewModel> Data { get; set; }
    }
}
