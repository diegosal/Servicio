namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebRecreationalArea.
    /// </summary>
    public class WebRecreationalArea
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the area.
        /// </summary>
        /// <value>The name of the area.</value>
        public string AreaName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebRecreationalArea"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
