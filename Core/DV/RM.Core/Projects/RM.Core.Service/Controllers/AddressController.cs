using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class AddressController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AddressController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web address.
        /// </summary>
        /// <param name="webAddress">The web address.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebAddress webAddress)
        {
            string response = crudFuction.BizInsertAddress(webAddress.WebAddressToBizAddress());

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
            List<WebAddress> webAdressList = crudFuction.BizGetAddress(id, active).ListBizAddressToListWebAddress();

            if (webAdressList == null)
                return BadRequest();
            else
                return Ok(webAdressList);
        }

        /// <summary>
        /// Puts the specified web address.
        /// </summary>
        /// <param name="webAddress">The web address.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebAddress webAddress)
        {
            string response = crudFuction.BizUpdateAddress(webAddress.WebAddressToBizAddress());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web address.
        /// </summary>
        /// <param name="webAddress">The web address.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebAddress webAddress)
        {
            string response = crudFuction.BizDeleteAddress(webAddress.WebAddressToBizAddress());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
