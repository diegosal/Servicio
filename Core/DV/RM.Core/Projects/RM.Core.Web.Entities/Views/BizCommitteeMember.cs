namespace RM.Core.Web.Entities.Views
{
    public class BizCommitteeMember
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommitteeTypeId { get; set; }
        public bool Active { get; set; }
    }
}
