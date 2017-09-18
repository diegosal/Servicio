using RM.Core.Business.Entities.Views;
using RM.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Data.Adapter
{
    public static class BaseAdapter
    {
        public static BizUser DataUserToBizUser(this SYSFuncLoginUser_Result DataUser)
        {
            BizUser bizUser = new BizUser
            {
                Id = DataUser.Id,
                CompanyId = 0,
                TypeId = DataUser.TypeId,
                UserName = DataUser.UserName,
                UserMiddleName = DataUser.UserMiddleName,
                UserLastName = DataUser.UserLastName,
                UserMotherName = DataUser.UserMotherName,
                Email = DataUser.Email,
                PassWord = DataUser.PassWord,
                PassWordSalt = DataUser.PassWordSalt,
                Active = DataUser.Active,
            };
            return bizUser;
        }
    }
}
