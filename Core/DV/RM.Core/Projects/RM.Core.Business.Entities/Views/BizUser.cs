namespace RM.Core.Business.Entities.Views
{
    /// <summary>
    /// Class BizUser.
    /// </summary>
    public class BizUser
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the company identifier.
        /// </summary>
        /// <value>The company identifier.</value>
        public int CompanyId { get; set; }
        /// <summary>
        /// Gets or sets the type identifier.
        /// </summary>
        /// <value>The type identifier.</value>
        public int TypeId { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>The type of the user.</value>
        public string UserType { get; set; }
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the name of the user middle.
        /// </summary>
        /// <value>The name of the user middle.</value>
        public string UserMiddleName { get; set; }
        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        /// <value>The last name of the user.</value>
        public string UserLastName { get; set; }
        /// <summary>
        /// Gets or sets the name of the user mother.
        /// </summary>
        /// <value>The name of the user mother.</value>
        public string UserMotherName { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the pass word.
        /// </summary>
        /// <value>The pass word.</value>
        public string PassWord { get; set; }
        /// <summary>
        /// Gets or sets the pass word salt.
        /// </summary>
        /// <value>The pass word salt.</value>
        public string PassWordSalt { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BizUser"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
