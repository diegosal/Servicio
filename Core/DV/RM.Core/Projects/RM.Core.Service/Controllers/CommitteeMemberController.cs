using RM.Core.Service.Adapters;
using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class CommitteeMemberController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebCommitteeMember webCommitteeMember)
        {
            string response = crudFuction.BizInsertCommitteeMember(webCommitteeMember.WebCommitteeMemberToBizCommitteeMember());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebCommitteeMember> webCommitteeMemberList = crudFuction.BizGetCommitteeMember(id, active).ListBizCommitteeMemberToListWebCommitteeMember();

            if (webCommitteeMemberList == null)
                return BadRequest();
            else
                return Ok(webCommitteeMemberList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebCommitteeMember webCommitteeMember)
        {
            string response = crudFuction.BizUpdateCommitteeMember(webCommitteeMember.WebCommitteeMemberToBizCommitteeMember());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebCommitteeMember webCommitteeMember)
        {
            string response = crudFuction.BizDeleteCommitteeMember(webCommitteeMember.WebCommitteeMemberToBizCommitteeMember());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
