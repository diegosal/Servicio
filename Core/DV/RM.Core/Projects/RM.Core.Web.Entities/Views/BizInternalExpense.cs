using System;

namespace RM.Core.Web.Entities.Views
{
    public class BizInternalExpense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
