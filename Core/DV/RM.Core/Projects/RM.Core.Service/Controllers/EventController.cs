using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class EventController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class EventController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web event.
        /// </summary>
        /// <param name="webEvent">The web event.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebEvent webEvent)
        {
            string response = crudFuction.BizInsertEvent(webEvent.BizEventToWebEvent());

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
            List<WebEvent> webEventList = crudFuction.BizGetEvent(id, active).ListBizEventToListWebEvent();

            if (webEventList == null)
                return BadRequest();
            else
                return Ok(webEventList);
        }

        /// <summary>
        /// Puts the specified web event.
        /// </summary>
        /// <param name="webEvent">The web event.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebEvent webEvent)
        {
            string response = crudFuction.BizUpdateEvent(webEvent.BizEventToWebEvent());

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
