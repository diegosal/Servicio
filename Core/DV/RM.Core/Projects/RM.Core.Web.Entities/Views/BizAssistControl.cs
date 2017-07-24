using System;

namespace RM.Core.Web.Entities.Views
{
    public class BizAssistControl
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
