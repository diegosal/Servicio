using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class PaymentStatusController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class PaymentStatusController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web payment status.
        /// </summary>
        /// <param name="webPaymentStatus">The web payment status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebPaymentStatus webPaymentStatus)
        {
            string response = crudFuction.BizInsertPaymentStatus(webPaymentStatus.WebPaymentStatusToBizPaymentStatus());

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
            List<WebPaymentStatus> webPaymentStatusList = crudFuction.BizGetPaymentStatus().ListBizPaymentStatusToListWebPaymentStatus();

            if (webPaymentStatusList == null)
                return BadRequest();
            else
                return Ok(webPaymentStatusList);
        }

        /// <summary>
        /// Puts the specified web payment status.
        /// </summary>
        /// <param name="webPaymentStatus">The web payment status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebPaymentStatus webPaymentStatus)
        {
            string response = crudFuction.BizUpdatePaymentStatus(webPaymentStatus.WebPaymentStatusToBizPaymentStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web payment status.
        /// </summary>
        /// <param name="webPaymentStatus">The web payment status.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebPaymentStatus webPaymentStatus)
        {
            string response = crudFuction.BizDeletePaymentStatus(webPaymentStatus.WebPaymentStatusToBizPaymentStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
