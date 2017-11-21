using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class TypeCommitteeController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebTypeCommittee webTypeCommittee)
        {
            string response = crudFuction.BizInsertTypeCommittee(webTypeCommittee.WebTypeCommitteeToBizTypeCommittee());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebTypeCommittee> webTypeCommitteeList = crudFuction.BizGetTypeCommittee(id, active).ListBizTypeCommitteeToListWebTypeCommittee();

            if (webTypeCommitteeList == null)
                return BadRequest();
            else
                return Ok(webTypeCommitteeList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebTypeCommittee webTypeCommittee)
        {
            string response = crudFuction.BizUpdateTypeCommittee(webTypeCommittee.WebTypeCommitteeToBizTypeCommittee());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebTypeCommittee webTypeCommittee)
        {
            string response = crudFuction.BizDeleteTypeCommittee(webTypeCommittee.WebTypeCommitteeToBizTypeCommittee());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
