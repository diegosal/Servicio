using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class InternalExpenseController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebInternalExpense webInternalExpense)
        {
            string response = crudFuction.BizInsertInternalExpense(webInternalExpense.WebInternalExpenseToBizInternalExpense());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebInternalExpense> webInternalExpense = crudFuction.BizGetInternalExpense().ListBizInternalExpenseToListWebInternalExpense();

            if (webInternalExpense == null)
                return BadRequest();
            else
                return Ok(webInternalExpense);
        }

        [HttpPut]
        public IHttpActionResult Put()
        {
            return Unauthorized();
        }

        [HttpDelete]
        public IHttpActionResult Delete()
        {
            return Unauthorized();
        }

    }
}
