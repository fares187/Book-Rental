using PeacockBook.web.Core.Models;
using PeacockBook.web.Core.Utilites;

namespace PeacockBook.web.Core.ViewModel
{
    public class RentalReportViewModel
    {
        public string Duration { get; set; } = null;
        public PaginatedList<ReportRentalsBooksViewModel> Rentals { get; set; }
    }
}
