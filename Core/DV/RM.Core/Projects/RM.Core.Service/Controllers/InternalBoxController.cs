using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class InternalBoxController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebInternalBox webInternalBox)
        {
            string response = crudFuction.BizInsertInternalBox(webInternalBox.WebInternalBoxToBizInternalBox());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(decimal? amount, DateTime? creationDate)
        {
            List<WebInternalBox> webInternalBoxList = crudFuction.BizGetInternalBox(amount, creationDate).ListBizInternalBoxToListWebInternalBox();

            if (webInternalBoxList == null)
                return BadRequest();
            else
                return Ok(webInternalBoxList);
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
