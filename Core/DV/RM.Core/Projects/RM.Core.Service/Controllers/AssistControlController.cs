using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class AssistControlController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebAssistControl webAssistControl)
        {
            string response = crudFuction.BizInsertAssistControl(webAssistControl.WebAssistControlToBizAssistControl());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebAssistControl> webAssistControlList = crudFuction.BizGetAssistControl(id, active).ListBizAssistControlToListWebAssistControl();

            if (webAssistControlList == null)
                return BadRequest();
            else
                return Ok(webAssistControlList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebAssistControl webAssistControl)
        {
            string response = crudFuction.BizUpdateAssistControl(webAssistControl.WebAssistControlToBizAssistControl());

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
