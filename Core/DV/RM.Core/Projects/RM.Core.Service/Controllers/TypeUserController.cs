using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class TypeUserController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TypeUserController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web type user.
        /// </summary>
        /// <param name="webTypeUser">The web type user.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebTypeUser webTypeUser)
        {
            string response = crudFuction.BizInsertTypeUser(webTypeUser.WebTypeUserToBizTypeUser());

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
            List<WebTypeUser> webTypeUserList = crudFuction.BizGetTypeUser(id, active).ListBizTypeUserToListWebTypeUser();

            if (webTypeUserList == null)
                return BadRequest();
            else
                return Ok(webTypeUserList);
        }

        /// <summary>
        /// Puts the specified web type user.
        /// </summary>
        /// <param name="webTypeUser">The web type user.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebTypeUser webTypeUser)
        {
            string response = crudFuction.BizUpdateTypeUser(webTypeUser.WebTypeUserToBizTypeUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web type user.
        /// </summary>
        /// <param name="webTypeUser">The web type user.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebTypeUser webTypeUser)
        {
            string response = crudFuction.BizDeleteTypeUser(webTypeUser.WebTypeUserToBizTypeUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
