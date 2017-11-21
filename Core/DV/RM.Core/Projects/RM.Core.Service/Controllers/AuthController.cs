using RM.Core.Business;
using RM.Core.Business.Entities.Views;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class AuthController : ApiController
    {
        private UserFunctions userFunctions = new UserFunctions();

        [HttpPost]
        public IHttpActionResult Post(WebUser user)
        {
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

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Unauthorized();
        }

        [HttpPut]
        public IHttpActionResult Put(WebUser user)
        {
            try
            {
                BizUser bizUser = user.WebUserToBizUser();
                string response = userFunctions.BizUpdateUserPassWord(bizUser);

                if (!response.Equals("EXITO"))
                    return BadRequest(response);
                else
                    return Ok(response);

            }

            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return Unauthorized();
        }
    }
}
