using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class PaymentController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebPayment webPayment)
        {
            string response = crudFuction.BizInsertPayment(webPayment.WebPaymentToBizPayment());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebPayment> webPaymentList = crudFuction.BizGetPayment(id, active).ListBizPaymentToListWebPayment();

            if (webPaymentList == null)
                return BadRequest();
            else
                return Ok(webPaymentList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebPayment webPayment)
        {
            string response = crudFuction.BizUpdatePayment(webPayment.WebPaymentToBizPayment());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete()
        {
            return Unauthorized();
        }
    }
}
