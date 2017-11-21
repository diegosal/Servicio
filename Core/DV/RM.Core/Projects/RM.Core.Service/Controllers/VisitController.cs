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
    public class VisitController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebVisit webVisit)
        {
            string response = crudFuction.BizInsertVisit(webVisit.WebVisitToBizVisit());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebVisit> webVisitist = crudFuction.BizGetVisit(id, active).ListBizVisitToListWebVisit();

            if (webVisitist == null)
                return BadRequest();
            else
                return Ok(webVisitist);
        }

        [HttpPut]
        public IHttpActionResult Put(WebVisit webVisit)
        {
            string response = crudFuction.BizUpdateVisit(webVisit.WebVisitToBizVisit());

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
