using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class RecreationalAreaController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebRecreationalArea webRecreationalArea)
        {
            string response = crudFuction.BizInsertRecreationalArea(webRecreationalArea.WebRecreationalAreaToBizRecreationalArea());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebRecreationalArea> webRecreationalAreaList = crudFuction.BizGetRecreationalArea(id, active).ListBizRecreationalAreaToListWebRecreationalArea();

            if (webRecreationalAreaList == null)
                return BadRequest();
            else
                return Ok(webRecreationalAreaList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebRecreationalArea webRecreationalArea)
        {
            string response = crudFuction.BizUpdateRecreationalArea(webRecreationalArea.WebRecreationalAreaToBizRecreationalArea());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebRecreationalArea webRecreationalArea)
        {
            string response = crudFuction.BizDeleteRecreationalArea(webRecreationalArea.WebRecreationalAreaToBizRecreationalArea());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
