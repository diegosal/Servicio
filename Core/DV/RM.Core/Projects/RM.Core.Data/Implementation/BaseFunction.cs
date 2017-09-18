using RM.Core.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Adapter;
using RM.Core.Data.Entities;

namespace RM.Core.Data.Implementation
{
    public class BaseFunction : BizLogic, IBaseFunction
    {
        public BizUser DataFuncLogin(string Email)
        {
            BizUser bizUser = new BizUser();
            string Result = BizCall(
                new Action(() =>
                {
                    bizUser = dbContext.SYSFuncLoginUser(Email).FirstOrDefault().DataUserToBizUser();
                }
                )
            );
            if (Result.Equals("EXITO"))
                return bizUser;
            else
                return null;
        }
    }
}
