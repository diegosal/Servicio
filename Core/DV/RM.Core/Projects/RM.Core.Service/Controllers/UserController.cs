using RM.Core.Business;
using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;
using RM.Core.Service.Adapters;
using System.Web.Http;
using System;
using System.Diagnostics;

namespace RM.Core.Service.Controllers
{
    public class UserController : ApiController
    {
        private UserFunctions userFunctions = new UserFunctions();
        private BizCrudFuntion bizInsert = new BizCrudFuntion();

        [Conditional("DEBUG_SERVICE")]
        private static void DebugMode()
        {
            Debugger.Break();
        }

        [HttpPost]
        public IHttpActionResult Post(WebUser user)
        {
            return BadRequest();
            //string result =  bizInsert.BizInsertUser(user.WebUserToBizUser());

            //if (result.Equals("EXITO"))
            //    return Ok(result);
            //else
            //    return BadRequest(result);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return BadRequest();
            //var configuration = new HttpConfiguration();
            //var request = new System.Net.Http.HttpRequestMessage();
            //request.Properties[System.Web.Http.Hosting.HttpPropertyKeys.HttpConfigurationKey] = configuration;
            
        }

        [HttpPut]
        public IHttpActionResult Put(int id)
        {
            return BadRequest();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return BadRequest();
        }
    }
}
