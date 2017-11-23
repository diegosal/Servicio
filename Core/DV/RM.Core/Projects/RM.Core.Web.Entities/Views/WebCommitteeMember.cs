namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebCommitteeMember.
    /// </summary>
    public class WebCommitteeMember
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the committee type identifier.
        /// </summary>
        /// <value>The committee type identifier.</value>
        public int CommitteeTypeId { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the type of the committee.
        /// </summary>
        /// <value>The type of the committee.</value>
        public string CommitteeType { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebCommitteeMember"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
