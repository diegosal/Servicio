namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebSupplier.
    /// </summary>
    public class WebSupplier
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        /// <value>The name of the supplier.</value>
        public string SupplierName { get; set; }
        /// <summary>
        /// Gets or sets the contact numer.
        /// </summary>
        /// <value>The contact numer.</value>
        public string ContactNumer { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebSupplier"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
