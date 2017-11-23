using System;
using RM.Core.Data.Entities;
using RM.Common.CustomException;

namespace RM.Core.Data.Biz
{
    /// <summary>
    /// Class BizLogic.
    /// </summary>
    public class BizLogic
    {
        /// <summary>
        /// The database context
        /// </summary>
        public RMModel dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="BizLogic"/> class.
        /// </summary>
        public BizLogic()
        {
            dbContext = new RMModel();
        }

        /// <summary>
        /// Bizs the call.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="RM.Common.CustomException.CustomException"></exception>
        public string BizCall(Action action)
        {
            try
            {
                action.Invoke();
                return "EXITO";
            }
            catch (Exception ex)
            {
                throw new CustomException();
            }
        }

    }
}
