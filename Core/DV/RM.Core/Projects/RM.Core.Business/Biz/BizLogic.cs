using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Business.Biz
{
    /// <summary>
    /// Class BizLogic.
    /// </summary>
    public class BizLogic
    {
        /// <summary>
        /// Bizs the call.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>System.String.</returns>
        public string BizCall(Action action)
        {
            try
            {
                action.Invoke();
                return "EXITO";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
