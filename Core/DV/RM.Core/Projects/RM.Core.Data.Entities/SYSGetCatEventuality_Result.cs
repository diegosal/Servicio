//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RM.Core.Data.Entities
{
    using System;

    /// <summary>
    /// Class SYSGetCatEventuality_Result.
    /// </summary>
    public partial class SYSGetCatEventuality_Result
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
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>The creation date.</value>
        public System.DateTime CreationDate { get; set; }
        /// <summary>
        /// Gets or sets the modification date.
        /// </summary>
        /// <value>The modification date.</value>
        public System.DateTime ModificationDate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SYSGetCatEventuality_Result"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
