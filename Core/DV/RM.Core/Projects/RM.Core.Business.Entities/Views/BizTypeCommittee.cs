namespace RM.Core.Business.Entities.Views
{
    /// <summary>
    /// Class BizTypeCommittee.
    /// </summary>
    public class BizTypeCommittee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the type committee.
        /// </summary>
        /// <value>The type committee.</value>
        public string TypeCommittee { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BizTypeCommittee"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
