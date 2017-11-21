using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class TypeVisitController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebTypeVisit webTypeVisit)
        {
            string response = crudFuction.BizInsertTypeVisit(webTypeVisit.WebTypeVisitToBizTypeVisit());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebTypeVisit> webTypeVisitList = crudFuction.BizGetTypeVisit(id, active).ListBizTypeVisitToListWebTypeVisit();

            if (webTypeVisitList == null)
                return BadRequest();
            else
                return Ok(webTypeVisitList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebTypeVisit webTypeVisit)
        {
            string response = crudFuction.BizUpdateTypeVisit(webTypeVisit.WebTypeVisitToBizTypeVisit());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebTypeVisit webTypeVisit)
        {
            string response = crudFuction.BizDeleteTypeVisit(webTypeVisit.WebTypeVisitToBizTypeVisit());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
