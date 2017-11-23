namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebEventStatus.
    /// </summary>
    public class WebEventStatus
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the status.
        /// </summary>
        /// <value>The name of the status.</value>
        public string StatusName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebEventStatus"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
