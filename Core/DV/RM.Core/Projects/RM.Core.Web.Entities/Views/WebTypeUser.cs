namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebTypeUser.
    /// </summary>
    public class WebTypeUser
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the type user.
        /// </summary>
        /// <value>The type user.</value>
        public string TypeUser { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebTypeUser"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
