using System;

namespace RM.Core.Web.Entities.Views
{
    public class WebInternalExpense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
