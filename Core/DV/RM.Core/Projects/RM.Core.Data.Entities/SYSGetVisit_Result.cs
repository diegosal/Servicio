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
    /// Class SYSGetVisit_Result.
    /// </summary>
    public partial class SYSGetVisit_Result
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the type visit.
        /// </summary>
        /// <value>The type visit.</value>
        public string TypeVisit { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the check in.
        /// </summary>
        /// <value>The check in.</value>
        public System.DateTime CheckIn { get; set; }
        /// <summary>
        /// Gets or sets the check out.
        /// </summary>
        /// <value>The check out.</value>
        public System.DateTime CheckOut { get; set; }
        /// <summary>
        /// Gets or sets the name of the visit.
        /// </summary>
        /// <value>The name of the visit.</value>
        public string VisitName { get; set; }
        /// <summary>
        /// Gets or sets the carnet.
        /// </summary>
        /// <value>The carnet.</value>
        public string Carnet { get; set; }
        /// <summary>
        /// Gets or sets the plates.
        /// </summary>
        /// <value>The plates.</value>
        public string Plates { get; set; }
    }
}
