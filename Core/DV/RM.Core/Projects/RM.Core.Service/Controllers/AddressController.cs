using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class AddressController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebAddress webAddress)
        {
            string response = crudFuction.BizInsertAddress(webAddress.WebAddressToBizAddress());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebAddress> webAdressList = crudFuction.BizGetAddress(id, active).ListBizAddressToListWebAddress();

            if (webAdressList == null)
                return BadRequest();
            else
                return Ok(webAdressList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebAddress webAddress)
        {
            string response = crudFuction.BizUpdateAddress(webAddress.WebAddressToBizAddress());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

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
