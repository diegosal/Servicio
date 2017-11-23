namespace RM.Common
{
    /// <summary>
    /// Class ExceptionMessage.
    /// </summary>
    public static class ExceptionMessage
    {
        /// <summary>
        /// The not unique email
        /// </summary>
        public const string NotUniqueEmail = "El correo ya se ha registrado intente de nuevo con un nuevo correo.";
        /// <summary>
        /// The database connection error
        /// </summary>
        public const string DbConnectionError = "Se presenta un error al consultar a la base de datos.";
        /// <summary>
        /// The constraint error
        /// </summary>
        public const string ConstraintError = "Hay un error al validar las llaves de la base de datos";
    }
}
