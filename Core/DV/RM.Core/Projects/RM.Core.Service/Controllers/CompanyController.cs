using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    /// <summary>
    /// Class CompanyController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class CompanyController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web company.
        /// </summary>
        /// <param name="webCompany">The web company.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebCompany webCompany)
        {
            string response = crudFuction.BizInsertCompany(webCompany.WebCompanyToBizCompany());

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
            List<WebCompany> webCompanyList = crudFuction.BizGetCompany(id, active).ListBizCompanyToListWebCompany();

            if (webCompanyList == null)
                return BadRequest();
            else
                return Ok(webCompanyList);
        }

        /// <summary>
        /// Puts the specified web company.
        /// </summary>
        /// <param name="webCompany">The web company.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebCompany webCompany)
        {
            string response = crudFuction.BizUpdateCompany(webCompany.WebCompanyToBizCompany());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web company.
        /// </summary>
        /// <param name="webCompany">The web company.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpDelete]
        public IHttpActionResult Delete(WebCompany webCompany)
        {
            string response = crudFuction.BizDeleteCompany(webCompany.WebCompanyToBizCompany());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
