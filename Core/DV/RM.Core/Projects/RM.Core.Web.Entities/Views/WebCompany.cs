namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebCompany.
    /// </summary>
    public class WebCompany
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebCompany"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
