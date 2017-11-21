using RM.Core.Business;
using RM.Core.Web.Entities.Views;
using RM.Core.Service.Adapters;
using System.Web.Http;
using System.Collections.Generic;

namespace RM.Core.Service.Controllers
{
    public class UserController : ApiController
    {
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebUser user)
        {
            string response = crudFuction.BizInsertUser(user.WebUserToBizUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebUser> webUserList = crudFuction.BizGetUser(id, active).ListBizUserToListWebUser();

            if (webUserList == null)
                return BadRequest();
            else
                return Ok(webUserList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebUser user)
        {
            string response = crudFuction.BizUpdateUser(user.WebUserToBizUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebUser user)
        {
            string response = crudFuction.BizDeleteUser(user.WebUserToBizUser());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }
    }
}
