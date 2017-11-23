using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class TypeVisitController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TypeVisitController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web type visit.
        /// </summary>
        /// <param name="webTypeVisit">The web type visit.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebTypeVisit webTypeVisit)
        {
            string response = crudFuction.BizInsertTypeVisit(webTypeVisit.WebTypeVisitToBizTypeVisit());

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
            List<WebTypeVisit> webTypeVisitList = crudFuction.BizGetTypeVisit(id, active).ListBizTypeVisitToListWebTypeVisit();

            if (webTypeVisitList == null)
                return BadRequest();
            else
                return Ok(webTypeVisitList);
        }

        /// <summary>
        /// Puts the specified web type visit.
        /// </summary>
        /// <param name="webTypeVisit">The web type visit.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebTypeVisit webTypeVisit)
        {
            string response = crudFuction.BizUpdateTypeVisit(webTypeVisit.WebTypeVisitToBizTypeVisit());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web type visit.
        /// </summary>
        /// <param name="webTypeVisit">The web type visit.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebTypeVisit webTypeVisit)
        {
            string response = crudFuction.BizDeleteTypeVisit(webTypeVisit.WebTypeVisitToBizTypeVisit());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
