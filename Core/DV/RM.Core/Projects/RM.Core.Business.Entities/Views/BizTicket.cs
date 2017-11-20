namespace RM.Core.Business.Entities.Views
{
    public class BizTicket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventualityId { get; set; }
        public int StatusId { get; set; }
        public string Nombre { get; set; }
        public string EventualityName { get; set; }
        public string StatusName { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime ModificationDate { get; set; }
    }
}
