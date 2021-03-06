﻿using System;

namespace RM.Core.Web.Entities.Views
{
    /// <summary>
    /// Class WebInternalExpense.
    /// </summary>
    public class WebInternalExpense
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
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public decimal Amount { get; set; }
        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>The creation date.</value>
        public DateTime CreationDate { get; set; }
    }
}
