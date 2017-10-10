using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;

namespace RM.Core.Service.Adapters
{
    public static class BaseAdapter
    {
        public static BizUser WebUserToBizUser(this WebUser User)
        {
            BizUser bizUser = new BizUser
            {
                Id = User.Id,
                CompanyId = User.CompanyId,
                TypeId = User.TypeId,
                UserName = User.UserName,
                UserMiddleName = User.UserMiddleName,
                UserLastName = User.UserLastName,
                UserMotherName = User.UserMotherName,
                Email = User.Email,
                PassWord = User.PassWord,
                PassWordSalt = User.PassWordSalt,
                Active = User.Active,
            };

            return bizUser;
        }

        public static WebUser BizUserToWebUser(this BizUser User)
        {
            WebUser webUser = new WebUser
            {
                Id = User.Id,
                CompanyId = User.CompanyId,
                TypeId = User.TypeId,
                UserName = User.UserName,
                UserMiddleName = User.UserMiddleName,
                UserLastName = User.UserLastName,
                UserMotherName = User.UserMotherName,
                Email = User.Email,
                PassWord = User.PassWord,
                PassWordSalt = User.PassWordSalt,
                Active = User.Active,
            };

            return webUser;
        }
    }
}