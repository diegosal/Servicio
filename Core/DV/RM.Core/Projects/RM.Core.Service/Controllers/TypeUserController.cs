using RM.Core.Business;
using RM.Core.Service.Adapters;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace RM.Core.Service.Controllers
{
    public class TypeUserController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebTypeUser webTypeUser)
        {
            string response = crudFuction.BizInsertTypeUser(webTypeUser.WebTypeUserToBizTypeUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebTypeUser> webTypeUserList = crudFuction.BizGetTypeUser(id, active).ListBizTypeUserToListWebTypeUser();

            if (webTypeUserList == null)
                return BadRequest();
            else
                return Ok(webTypeUserList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebTypeUser webTypeUser)
        {
            string response = crudFuction.BizUpdateTypeUser(webTypeUser.WebTypeUserToBizTypeUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebTypeUser webTypeUser)
        {
            string response = crudFuction.BizDeleteTypeUser(webTypeUser.WebTypeUserToBizTypeUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
