using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class InternalBoxController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class InternalBoxController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web internal box.
        /// </summary>
        /// <param name="webInternalBox">The web internal box.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebInternalBox webInternalBox)
        {
            string response = crudFuction.BizInsertInternalBox(webInternalBox.WebInternalBoxToBizInternalBox());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Gets the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="creationDate">The creation date.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        public IHttpActionResult Get(decimal? amount, DateTime? creationDate)
        {
            List<WebInternalBox> webInternalBoxList = crudFuction.BizGetInternalBox(amount, creationDate).ListBizInternalBoxToListWebInternalBox();

            if (webInternalBoxList == null)
                return BadRequest();
            else
                return Ok(webInternalBoxList);
        }

        /// <summary>
        /// Puts this instance.
        /// </summary>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put()
        {
            return Unauthorized();
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
