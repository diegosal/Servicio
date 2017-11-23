namespace RM.Core.Business.Entities.Views
{
    /// <summary>
    /// Class BizEventuality.
    /// </summary>
    public class BizEventuality
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
        /// Gets or sets a value indicating whether this <see cref="BizEventuality"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
