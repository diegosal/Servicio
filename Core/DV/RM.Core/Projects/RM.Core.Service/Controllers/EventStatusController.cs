using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class EventStatusController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class EventStatusController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web event status.
        /// </summary>
        /// <param name="webEventStatus">The web event status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebEventStatus webEventStatus)
        {
            string response = crudFuction.BizInsertEventStatus(webEventStatus.WebEventStatusToBizEventStatus());

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
            List<WebEventStatus> webEventStatusList = crudFuction.BizGetEventStatus(id, active).ListBizEventStatusToListWebEventStatus();

            if (webEventStatusList == null)
                return BadRequest();
            else
                return Ok(webEventStatusList);
        }

        /// <summary>
        /// Puts the specified web event status.
        /// </summary>
        /// <param name="webEventStatus">The web event status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebEventStatus webEventStatus)
        {
            string response = crudFuction.BizUpdateEventStatus(webEventStatus.WebEventStatusToBizEventStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web event status.
        /// </summary>
        /// <param name="webEventStatus">The web event status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebEventStatus webEventStatus)
        {
            string response = crudFuction.BizDeleteEventStatus(webEventStatus.WebEventStatusToBizEventStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
