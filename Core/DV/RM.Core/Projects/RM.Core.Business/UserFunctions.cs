using PasswordSecurity;
using RM.Core.Business.Biz;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Implementation;
using System;

namespace RM.Core.Business
{
    /// <summary>
    /// Class UserFunctions.
    /// </summary>
    /// <seealso cref="RM.Core.Business.Biz.BizLogic" />
    public class UserFunctions : BizLogic
    {
        /// <summary>
        /// The base funtion
        /// </summary>
        private BaseFunction baseFuntion = new BaseFunction();

        /// <summary>
        /// Bizs the function login.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="PassWord">The pass word.</param>
        /// <returns>BizUser.</returns>
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

        /// <summary>
        /// Bizs the update user pass word.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateUserPassWord(BizUser bizUser)
        {
            bizUser.PassWord = PasswordStorage.CreateHash(bizUser.PassWord);
            return BizCall(
                   new Action(() =>
                   {
                       baseFuntion.UpdateUserPassWord(bizUser);
                   }
                   )
            );
        }
    }
}
