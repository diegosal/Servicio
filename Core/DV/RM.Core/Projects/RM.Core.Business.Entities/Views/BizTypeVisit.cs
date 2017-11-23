namespace RM.Core.Business.Entities.Views
{
    /// <summary>
    /// Class BizTypeVisit.
    /// </summary>
    public class BizTypeVisit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the type visit.
        /// </summary>
        /// <value>The type visit.</value>
        public string TypeVisit { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BizTypeVisit"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
