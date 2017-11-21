using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class CompanyController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebCompany webCompany)
        {
            string response = crudFuction.BizInsertCompany(webCompany.WebCompanyToBizCompany());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebCompany> webCompanyList = crudFuction.BizGetCompany(id, active).ListBizCompanyToListWebCompany();

            if (webCompanyList == null)
                return BadRequest();
            else
                return Ok(webCompanyList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebCompany webCompany)
        {
            string response = crudFuction.BizUpdateCompany(webCompany.WebCompanyToBizCompany());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

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
