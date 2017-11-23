using RM.Core.Business.Entities.Views;

namespace RM.Core.Data.Interface
{
    /// <summary>
    /// Interface IBaseFunction
    /// </summary>
    interface IBaseFunction
    {
        /// <summary>
        /// Datas the function login.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns>BizUser.</returns>
        BizUser DataFuncLogin(string Email);
        /// <summary>
        /// Updates the user pass word.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        string UpdateUserPassWord(BizUser bizUser);
    }
}
