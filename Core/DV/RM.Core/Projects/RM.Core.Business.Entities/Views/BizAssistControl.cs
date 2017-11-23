using System;

namespace RM.Core.Business.Entities.Views
{
    /// <summary>
    /// Class BizAssistControl.
    /// </summary>
    public class BizAssistControl
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
