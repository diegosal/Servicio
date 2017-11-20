namespace RM.Core.Web.Entities.Views
{
    public class WebUser
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public string CompanyName { get; set; }
        public string UserType { get; set; }
        public string UserName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserLastName { get; set; }
        public string UserMotherName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string PassWordSalt { get; set; }
        public bool Active { get; set; }
    }
}
