using System;

namespace RM.Core.Business.Entities.Views
{
    public class BizEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecreationalAreaId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
    }
}
