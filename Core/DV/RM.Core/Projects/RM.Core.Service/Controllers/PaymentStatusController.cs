using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class PaymentStatusController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebPaymentStatus webPaymentStatus)
        {
            string response = crudFuction.BizInsertPaymentStatus(webPaymentStatus.WebPaymentStatusToBizPaymentStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebPaymentStatus> webPaymentStatusList = crudFuction.BizGetPaymentStatus().ListBizPaymentStatusToListWebPaymentStatus();

            if (webPaymentStatusList == null)
                return BadRequest();
            else
                return Ok(webPaymentStatusList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebPaymentStatus webPaymentStatus)
        {
            string response = crudFuction.BizUpdatePaymentStatus(webPaymentStatus.WebPaymentStatusToBizPaymentStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

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
