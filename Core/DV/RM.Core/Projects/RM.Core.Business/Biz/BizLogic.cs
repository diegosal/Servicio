using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Business.Biz
{
    public class BizLogic
    {
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
