using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class SupplierController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebSupplier webSupplier)
        {
            string response = crudFuction.BizInsertSupplier(webSupplier.WebSupplierToBizSupplier());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebSupplier> webSupplierList = crudFuction.BizGetSupplier(id, active).ListBizSupplierToListWebSupplier();

            if (webSupplierList == null)
                return BadRequest();
            else
                return Ok(webSupplierList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebSupplier webSupplier)
        {
            string response = crudFuction.BizUpdateSupplier(webSupplier.WebSupplierToBizSupplier());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

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
