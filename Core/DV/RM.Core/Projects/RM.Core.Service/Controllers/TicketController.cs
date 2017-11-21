using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class TicketController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebTicket webTicket)
        {
            string response = crudFuction.BizInsertTicket(webTicket.WebTicketToBizTicket());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebTicket> webTicketList = crudFuction.BizGetTicket().ListBizTicketToListWebTicket();

            if (webTicketList == null)
                return BadRequest();
            else
                return Ok(webTicketList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebTicket webTicket)
        {
            string response = crudFuction.BizUpdateTicket(webTicket.WebTicketToBizTicket());

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
