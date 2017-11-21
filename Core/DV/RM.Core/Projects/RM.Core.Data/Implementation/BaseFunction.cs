using RM.Core.Data.Interface;
using System;
using System.Linq;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Adapter;

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
                    bizUser = dbContext.SYSFuncLoginUser(Email).FirstOrDefault().DataUserLogInToBizUser();
                }
                )
            );
            if (Result.Equals("EXITO"))
                return bizUser;
            else
                return null;
        }

        public string UpdateUserPassWord(BizUser bizUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdUserPassWord(
                                      bizUser.Id,
                                      bizUser.PassWord,
                                      bizUser.PassWordSalt
                        );
                }
                )
            );
            return Result;
        }
    }
}
