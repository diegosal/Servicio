using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using RM.Core.Service.Adapters;
using System.Web.Http;
using System.Collections.Generic;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class UserController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class UserController : ApiController
    {
        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebUser user)
        {
            string response = crudFuction.BizInsertUser(user.WebUserToBizUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="active">if set to <c>true</c> [active].</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebUser> webUserList = crudFuction.BizGetUser(id, active).ListBizUserToListWebUser();

            if (webUserList == null)
                return BadRequest();
            else
                return Ok(webUserList);
        }

        /// <summary>
        /// Puts the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebUser user)
        {
            string response = crudFuction.BizUpdateUser(user.WebUserToBizUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebUser user)
        {
            string response = crudFuction.BizDeleteUser(user.WebUserToBizUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }
    }
}
