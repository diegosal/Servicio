using System;

namespace RM.Core.Business.Entities.Views
{
    public class BizPayment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Amount { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
