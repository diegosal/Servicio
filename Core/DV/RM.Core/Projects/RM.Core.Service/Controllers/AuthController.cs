using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using RM.Core.Service.Adapters;
using RM.Core.Business.Entities.Views;
using System;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class AuthController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AuthController : ApiController
    {
        /// <summary>
        /// The user functions
        /// </summary>
        private UserFunctions userFunctions = new UserFunctions();

        /// <summary>
        /// Posts the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>IHttpActionResult.</returns>
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

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Unauthorized();
        }

        /// <summary>
        /// Puts the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>IHttpActionResult.</returns>
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
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete()
        {
            return Unauthorized();
        }
    }
}
