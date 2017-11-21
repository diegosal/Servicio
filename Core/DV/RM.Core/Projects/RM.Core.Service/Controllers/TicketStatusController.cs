using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class TicketStatusController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebTicketStatus webTicketStatus)
        {
            string response = crudFuction.BizInsertTicketStatus(webTicketStatus.WebTicketStatusToBizTicketStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebTicketStatus> webTicketStatusList = crudFuction.BizGetTicketStatus(id, active).ListBizTicketStatusToListWebTicketStatus();

            if (webTicketStatusList == null)
                return BadRequest();
            else
                return Ok(webTicketStatusList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebTicketStatus webTicketStatus)
        {
            string response = crudFuction.BizUpdateTicketStatus(webTicketStatus.WebTicketStatusToBizTicketStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebTicketStatus webTicketStatus)
        {
            string response = crudFuction.BizDeleteTicketStatus(webTicketStatus.WebTicketStatusToBizTicketStatus());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
