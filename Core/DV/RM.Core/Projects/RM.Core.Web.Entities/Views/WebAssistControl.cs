using System;

namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebAssistControl.
    /// </summary>
    public class WebAssistControl
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
        /// Gets or sets the check in.
        /// </summary>
        /// <value>The check in.</value>
        public DateTime CheckIn { get; set; }
        /// <summary>
        /// Gets or sets the check out.
        /// </summary>
        /// <value>The check out.</value>
        public DateTime CheckOut { get; set; }
    }
}
