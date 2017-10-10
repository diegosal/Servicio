using RM.Core.Business;
using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;
using RM.Core.Service.Adapters;
using System.Web.Http;
using System;
using System.Diagnostics;

namespace RM.Core.Service.Controllers
{
    public class UserController : ApiController
    {
        private UserFunctions userFunctions = new UserFunctions();
        private BizInsert bizInsert = new BizInsert();

        [Conditional("DEBUG_SERVICE")]
        private static void DebugMode()
        {
            Debugger.Break();
        }

        [HttpPost]
        public IHttpActionResult Register(WebUser user)
        {
            string result =  bizInsert.BizInsertUser(user.WebUserToBizUser());

            if (result.Equals("EXITO"))
                return Ok(result);
            else
                return BadRequest(result);
        }

        

        [HttpPost]
        public IHttpActionResult LogIn(WebUser user)
        {
            var configuration = new HttpConfiguration();
            var request = new System.Net.Http.HttpRequestMessage();
            request.Properties[System.Web.Http.Hosting.HttpPropertyKeys.HttpConfigurationKey] = configuration;
            try
            {
                BizUser bizUser = user.WebUserToBizUser();
                WebUser userResponse = userFunctions.BizFuncLogin(bizUser.Email, bizUser.PassWord).BizUserToWebUser();

                if (userResponse == null)
                    return Unauthorized();
                else
                    return Ok(userResponse);

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
