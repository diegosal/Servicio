using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class InternalExpenseController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class InternalExpenseController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web internal expense.
        /// </summary>
        /// <param name="webInternalExpense">The web internal expense.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebInternalExpense webInternalExpense)
        {
            string response = crudFuction.BizInsertInternalExpense(webInternalExpense.WebInternalExpenseToBizInternalExpense());

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
            List<WebInternalExpense> webInternalExpense = crudFuction.BizGetInternalExpense().ListBizInternalExpenseToListWebInternalExpense();

            if (webInternalExpense == null)
                return BadRequest();
            else
                return Ok(webInternalExpense);
        }

        /// <summary>
        /// Puts this instance.
        /// </summary>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put()
        {
            return Unauthorized();
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
