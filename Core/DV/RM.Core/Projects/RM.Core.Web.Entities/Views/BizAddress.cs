namespace RM.Core.Web.Entities.Views
{
    public class BizAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public bool Active { get; set; }
    }
}
