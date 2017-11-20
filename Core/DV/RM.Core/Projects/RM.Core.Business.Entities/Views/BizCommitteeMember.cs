namespace RM.Core.Business.Entities.Views
{
    public class BizCommitteeMember
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommitteeTypeId { get; set; }
        public string Nombre { get; set; }
        public string CommitteeType { get; set; }
        public bool Active { get; set; }
    }
}
