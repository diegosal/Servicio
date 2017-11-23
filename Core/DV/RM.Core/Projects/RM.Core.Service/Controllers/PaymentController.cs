using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class PaymentController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class PaymentController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web payment.
        /// </summary>
        /// <param name="webPayment">The web payment.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebPayment webPayment)
        {
            string response = crudFuction.BizInsertPayment(webPayment.WebPaymentToBizPayment());

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
            List<WebPayment> webPaymentList = crudFuction.BizGetPayment(id, active).ListBizPaymentToListWebPayment();

            if (webPaymentList == null)
                return BadRequest();
            else
                return Ok(webPaymentList);
        }

        /// <summary>
        /// Puts the specified web payment.
        /// </summary>
        /// <param name="webPayment">The web payment.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebPayment webPayment)
        {
            string response = crudFuction.BizUpdatePayment(webPayment.WebPaymentToBizPayment());

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
