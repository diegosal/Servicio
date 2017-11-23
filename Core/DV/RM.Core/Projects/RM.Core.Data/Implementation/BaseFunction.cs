using RM.Core.Data.Interface;
using System;
using System.Linq;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Adapter;

namespace RM.Core.Data.Implementation
{
    /// <summary>
    /// Class BaseFunction.
    /// </summary>
    /// <seealso cref="RM.Core.Data.Biz.BizLogic" />
    /// <seealso cref="RM.Core.Data.Interface.IBaseFunction" />
    public class BaseFunction : BizLogic, IBaseFunction
    {
        /// <summary>
        /// Datas the function login.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns>BizUser.</returns>
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

        /// <summary>
        /// Updates the user password.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
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
