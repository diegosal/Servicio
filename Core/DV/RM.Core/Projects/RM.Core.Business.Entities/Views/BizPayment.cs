using System;

namespace RM.Core.Business.Entities.Views
{
    public class BizPayment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Nombre { get; set; }
        public string StatusName { get; set; }
        public decimal Amount { get; set; }
        public int PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
