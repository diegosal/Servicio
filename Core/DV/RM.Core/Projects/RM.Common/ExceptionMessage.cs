using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Common
{
    public static class ExceptionMessage
    {
        public const string NotUniqueEmail = "El correo ya se ha registrado intente de nuevo con un nuevo correo.";
        public const string DbConnectionError = "Se presenta un error al consultar a la base de datos.";
        public const string ConstraintError = "Hay un error al validar las llaves de la base de datos";
    }
}
