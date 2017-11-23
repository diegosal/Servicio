using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class TicketStatusController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TicketStatusController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web ticket status.
        /// </summary>
        /// <param name="webTicketStatus">The web ticket status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebTicketStatus webTicketStatus)
        {
            string response = crudFuction.BizInsertTicketStatus(webTicketStatus.WebTicketStatusToBizTicketStatus());

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
            List<WebTicketStatus> webTicketStatusList = crudFuction.BizGetTicketStatus(id, active).ListBizTicketStatusToListWebTicketStatus();

            if (webTicketStatusList == null)
                return BadRequest();
            else
                return Ok(webTicketStatusList);
        }

        /// <summary>
        /// Puts the specified web ticket status.
        /// </summary>
        /// <param name="webTicketStatus">The web ticket status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebTicketStatus webTicketStatus)
        {
            string response = crudFuction.BizUpdateTicketStatus(webTicketStatus.WebTicketStatusToBizTicketStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web ticket status.
        /// </summary>
        /// <param name="webTicketStatus">The web ticket status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebTicketStatus webTicketStatus)
        {
            string response = crudFuction.BizDeleteTicketStatus(webTicketStatus.WebTicketStatusToBizTicketStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
