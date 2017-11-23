using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class AssistControlController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AssistControlController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web assist control.
        /// </summary>
        /// <param name="webAssistControl">The web assist control.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebAssistControl webAssistControl)
        {
            string response = crudFuction.BizInsertAssistControl(webAssistControl.WebAssistControlToBizAssistControl());

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
            List<WebAssistControl> webAssistControlList = crudFuction.BizGetAssistControl(id, active).ListBizAssistControlToListWebAssistControl();

            if (webAssistControlList == null)
                return BadRequest();
            else
                return Ok(webAssistControlList);
        }

        /// <summary>
        /// Puts the specified web assist control.
        /// </summary>
        /// <param name="webAssistControl">The web assist control.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebAssistControl webAssistControl)
        {
            string response = crudFuction.BizUpdateAssistControl(webAssistControl.WebAssistControlToBizAssistControl());

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
