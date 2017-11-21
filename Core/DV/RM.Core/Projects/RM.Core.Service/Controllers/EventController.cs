using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class EventController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebEvent webEvent)
        {
            string response = crudFuction.BizInsertEvent(webEvent.BizEventToWebEvent());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebEvent> webEventList = crudFuction.BizGetEvent(id, active).ListBizEventToListWebEvent();

            if (webEventList == null)
                return BadRequest();
            else
                return Ok(webEventList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebEvent webEvent)
        {
            string response = crudFuction.BizUpdateEvent(webEvent.BizEventToWebEvent());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete()
        {
            return Unauthorized();
        }

    }
}
