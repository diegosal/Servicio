using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class EventualityController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class EventualityController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web eventuality.
        /// </summary>
        /// <param name="webEventuality">The web eventuality.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebEventuality webEventuality)
        {
            string response = crudFuction.BizInsertEventuality(webEventuality.WebEventualityToBizEventuality());

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
            List<WebEventuality> webEventualityList = crudFuction.BizGetEventuality(id, active).ListBizAEventualityToListWebEventuality();

            if (webEventualityList == null)
                return BadRequest();
            else
                return Ok(webEventualityList);
        }

        /// <summary>
        /// Puts the specified web eventuality.
        /// </summary>
        /// <param name="webEventuality">The web eventuality.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebEventuality webEventuality)
        {
            string response = crudFuction.BizUpdateEventuality(webEventuality.WebEventualityToBizEventuality());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web eventuality.
        /// </summary>
        /// <param name="webEventuality">The web eventuality.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebEventuality webEventuality)
        {
            string response = crudFuction.BizDeleteEventuality(webEventuality.WebEventualityToBizEventuality());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
