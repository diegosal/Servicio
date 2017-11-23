using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class RecreationalAreaController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class RecreationalAreaController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web recreational area.
        /// </summary>
        /// <param name="webRecreationalArea">The web recreational area.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebRecreationalArea webRecreationalArea)
        {
            string response = crudFuction.BizInsertRecreationalArea(webRecreationalArea.WebRecreationalAreaToBizRecreationalArea());

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
            List<WebRecreationalArea> webRecreationalAreaList = crudFuction.BizGetRecreationalArea(id, active).ListBizRecreationalAreaToListWebRecreationalArea();

            if (webRecreationalAreaList == null)
                return BadRequest();
            else
                return Ok(webRecreationalAreaList);
        }

        /// <summary>
        /// Puts the specified web recreational area.
        /// </summary>
        /// <param name="webRecreationalArea">The web recreational area.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebRecreationalArea webRecreationalArea)
        {
            string response = crudFuction.BizUpdateRecreationalArea(webRecreationalArea.WebRecreationalAreaToBizRecreationalArea());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web recreational area.
        /// </summary>
        /// <param name="webRecreationalArea">The web recreational area.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebRecreationalArea webRecreationalArea)
        {
            string response = crudFuction.BizDeleteRecreationalArea(webRecreationalArea.WebRecreationalAreaToBizRecreationalArea());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
