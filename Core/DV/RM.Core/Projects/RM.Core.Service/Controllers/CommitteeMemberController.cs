using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class CommitteeMemberController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class CommitteeMemberController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web committee member.
        /// </summary>
        /// <param name="webCommitteeMember">The web committee member.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebCommitteeMember webCommitteeMember)
        {
            string response = crudFuction.BizInsertCommitteeMember(webCommitteeMember.WebCommitteeMemberToBizCommitteeMember());

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
            List<WebCommitteeMember> webCommitteeMemberList = crudFuction.BizGetCommitteeMember(id, active).ListBizCommitteeMemberToListWebCommitteeMember();

            if (webCommitteeMemberList == null)
                return BadRequest();
            else
                return Ok(webCommitteeMemberList);
        }

        /// <summary>
        /// Puts the specified web committee member.
        /// </summary>
        /// <param name="webCommitteeMember">The web committee member.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebCommitteeMember webCommitteeMember)
        {
            string response = crudFuction.BizUpdateCommitteeMember(webCommitteeMember.WebCommitteeMemberToBizCommitteeMember());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web committee member.
        /// </summary>
        /// <param name="webCommitteeMember">The web committee member.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebCommitteeMember webCommitteeMember)
        {
            string response = crudFuction.BizDeleteCommitteeMember(webCommitteeMember.WebCommitteeMemberToBizCommitteeMember());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
