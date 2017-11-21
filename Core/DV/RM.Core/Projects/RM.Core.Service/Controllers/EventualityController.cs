using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class EventualityController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebEventuality webEventuality)
        {
            string response = crudFuction.BizInsertEventuality(webEventuality.WebEventualityToBizEventuality());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebEventuality> webEventualityList = crudFuction.BizGetEventuality(id, active).ListBizAEventualityToListWebEventuality();

            if (webEventualityList == null)
                return BadRequest();
            else
                return Ok(webEventualityList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebEventuality webEventuality)
        {
            string response = crudFuction.BizUpdateEventuality(webEventuality.WebEventualityToBizEventuality());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebEventuality webEventuality)
        {
            string response = crudFuction.BizDeleteEventuality(webEventuality.WebEventualityToBizEventuality());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
