using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;

namespace PeacockBook.web.Core.ViewModel
{
    public class ReturnCopyViewModel
    {
        public int Id { get; set; } 
        public bool? IsReturned { get; set; }
    }
}
