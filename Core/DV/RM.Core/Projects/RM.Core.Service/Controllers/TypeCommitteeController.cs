using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class TypeCommitteeController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TypeCommitteeController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web type committee.
        /// </summary>
        /// <param name="webTypeCommittee">The web type committee.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebTypeCommittee webTypeCommittee)
        {
            string response = crudFuction.BizInsertTypeCommittee(webTypeCommittee.WebTypeCommitteeToBizTypeCommittee());

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
            List<WebTypeCommittee> webTypeCommitteeList = crudFuction.BizGetTypeCommittee(id, active).ListBizTypeCommitteeToListWebTypeCommittee();

            if (webTypeCommitteeList == null)
                return BadRequest();
            else
                return Ok(webTypeCommitteeList);
        }

        /// <summary>
        /// Puts the specified web type committee.
        /// </summary>
        /// <param name="webTypeCommittee">The web type committee.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebTypeCommittee webTypeCommittee)
        {
            string response = crudFuction.BizUpdateTypeCommittee(webTypeCommittee.WebTypeCommitteeToBizTypeCommittee());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web type committee.
        /// </summary>
        /// <param name="webTypeCommittee">The web type committee.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebTypeCommittee webTypeCommittee)
        {
            string response = crudFuction.BizDeleteTypeCommittee(webTypeCommittee.WebTypeCommitteeToBizTypeCommittee());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
