using PasswordSecurity;
using RM.Core.Business.Biz;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Implementation;
using System;

namespace RM.Core.Business
{
    public class UserFunctions : BizLogic
    {
        private BaseFunction baseFuntion = new BaseFunction();

        public BizUser BizFuncLogin(string Email, string PassWord)
        {
            BizUser bizUser = new BizUser();

            string Result = BizCall(
              new Action(() =>
              {
                  bizUser =  baseFuntion.DataFuncLogin(Email);
              }
              )
            );

            if (Result.Equals("EXITO"))
            {
                if (PasswordStorage.VerifyPassword(PassWord, bizUser.PassWord))
                    return bizUser;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
    }
}
