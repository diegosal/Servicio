using System;

namespace RM.Core.Business.Entities.Views
{
    /// <summary>
    /// Class BizVisit.
    /// </summary>
    public class BizVisit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the visit identifier.
        /// </summary>
        /// <value>The visit identifier.</value>
        public int VisitId { get; set; }
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
