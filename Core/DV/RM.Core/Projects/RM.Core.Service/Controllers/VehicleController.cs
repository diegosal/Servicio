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
    public class VehicleController : ApiController
    {

        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        [HttpPost]
        public IHttpActionResult Post(WebVehicle webVehicle)
        {
            string response = crudFuction.BizInsertVehicle(webVehicle.WebVehicleToBizVehicle());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebVehicle> webVehicleList = crudFuction.BizGetVehicle(id, active).ListBizVehicleToListWebVehicle();

            if (webVehicleList == null)
                return BadRequest();
            else
                return Ok(webVehicleList);
        }

        [HttpPut]
        public IHttpActionResult Put(WebVehicle webVehicle)
        {
            string response = crudFuction.BizUpdateVehicle(webVehicle.WebVehicleToBizVehicle());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(WebVehicle webVehicle)
        {
            string response = crudFuction.BizDeleteVehicle(webVehicle.WebVehicleToBizVehicle());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

    }
}
