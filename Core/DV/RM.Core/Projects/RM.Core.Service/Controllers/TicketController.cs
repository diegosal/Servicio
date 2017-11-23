using RM.Core.Business;
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
    /// <summary>
    /// Class TicketController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TicketController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web ticket.
        /// </summary>
        /// <param name="webTicket">The web ticket.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebTicket webTicket)
        {
            string response = crudFuction.BizInsertTicket(webTicket.WebTicketToBizTicket());

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
            List<WebTicket> webTicketList = crudFuction.BizGetTicket().ListBizTicketToListWebTicket();

            if (webTicketList == null)
                return BadRequest();
            else
                return Ok(webTicketList);
        }

        /// <summary>
        /// Puts the specified web ticket.
        /// </summary>
        /// <param name="webTicket">The web ticket.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebTicket webTicket)
        {
            string response = crudFuction.BizUpdateTicket(webTicket.WebTicketToBizTicket());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
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
