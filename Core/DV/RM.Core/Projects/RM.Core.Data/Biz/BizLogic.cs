using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM.Core.Data.Entities;
namespace RM.Core.Data.Biz
{
    public class BizLogic
    {
        public RMModel dbContext;

        public BizLogic()
        {
            dbContext = new RMModel();
        }

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
