using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class SupplierController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class SupplierController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web supplier.
        /// </summary>
        /// <param name="webSupplier">The web supplier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebSupplier webSupplier)
        {
            string response = crudFuction.BizInsertSupplier(webSupplier.WebSupplierToBizSupplier());

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
            List<WebSupplier> webSupplierList = crudFuction.BizGetSupplier(id, active).ListBizSupplierToListWebSupplier();

            if (webSupplierList == null)
                return BadRequest();
            else
                return Ok(webSupplierList);
        }

        /// <summary>
        /// Puts the specified web supplier.
        /// </summary>
        /// <param name="webSupplier">The web supplier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebSupplier webSupplier)
        {
            string response = crudFuction.BizUpdateSupplier(webSupplier.WebSupplierToBizSupplier());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web supplier.
        /// </summary>
        /// <param name="webSupplier">The web supplier.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebSupplier webSupplier)
        {
            string response = crudFuction.BizDeleteSupplier(webSupplier.WebSupplierToBizSupplier());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
