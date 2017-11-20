using System;

namespace RM.Core.Web.Entities.Views
{
    public class WebEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecreationalAreaId { get; set; }
        public string Nombre { get; set; }
        public string StatusName { get; set; }
        public string AreaName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
    }
}
