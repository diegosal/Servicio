using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class EventStatusController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebEventStatus webEventStatus)
        {
            string response = crudFuction.BizInsertEventStatus(webEventStatus.WebEventStatusToBizEventStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebEventStatus> webEventStatusList = crudFuction.BizGetEventStatus(id, active).ListBizEventStatusToListWebEventStatus();

            if (webEventStatusList == null)
                return BadRequest();
            else
                return Ok(webEventStatusList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebEventStatus webEventStatus)
        {
            string response = crudFuction.BizUpdateEventStatus(webEventStatus.WebEventStatusToBizEventStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebEventStatus webEventStatus)
        {
            string response = crudFuction.BizDeleteEventStatus(webEventStatus.WebEventStatusToBizEventStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
