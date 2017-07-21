namespace RM.Core.Business.Entities.Views
{
    public class BizCommitteeMember
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CommitteeTypeId { get; set; }
        public bool Active { get; set; }
    }
}
