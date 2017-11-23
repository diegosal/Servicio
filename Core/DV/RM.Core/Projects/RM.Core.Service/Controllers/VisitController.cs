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
    /// Class VisitController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class VisitController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web visit.
        /// </summary>
        /// <param name="webVisit">The web visit.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebVisit webVisit)
        {
            string response = crudFuction.BizInsertVisit(webVisit.WebVisitToBizVisit());

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
            List<WebVisit> webVisitist = crudFuction.BizGetVisit(id, active).ListBizVisitToListWebVisit();

            if (webVisitist == null)
                return BadRequest();
            else
                return Ok(webVisitist);
        }

        /// <summary>
        /// Puts the specified web visit.
        /// </summary>
        /// <param name="webVisit">The web visit.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebVisit webVisit)
        {
            string response = crudFuction.BizUpdateVisit(webVisit.WebVisitToBizVisit());

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
