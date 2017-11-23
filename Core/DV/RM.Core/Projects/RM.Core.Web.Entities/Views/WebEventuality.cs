namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebEventuality.
    /// </summary>
    public class WebEventuality
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the eventuality.
        /// </summary>
        /// <value>The name of the eventuality.</value>
        public string EventualityName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebEventuality"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
