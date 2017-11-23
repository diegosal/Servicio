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
    /// <summary>
    /// Class VehicleController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class VehicleController : ApiController
    {

        /// <summary>
        /// The crud fuction
        /// </summary>
        private BizCrudFuntion crudFuction = new BizCrudFuntion();

        /// <summary>
        /// Posts the specified web vehicle.
        /// </summary>
        /// <param name="webVehicle">The web vehicle.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPost]
        public IHttpActionResult Post(WebVehicle webVehicle)
        {
            string response = crudFuction.BizInsertVehicle(webVehicle.WebVehicleToBizVehicle());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="active">if set to <c>true</c> [active].</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpGet]
        public IHttpActionResult Get(int? id = null, bool? active = null)
        {
            List<WebVehicle> webVehicleList = crudFuction.BizGetVehicle(id, active).ListBizVehicleToListWebVehicle();

            if (webVehicleList == null)
                return BadRequest();
            else
                return Ok(webVehicleList);
        }

        /// <summary>
        /// Puts the specified web vehicle.
        /// </summary>
        /// <param name="webVehicle">The web vehicle.</param>
        /// <returns>IHttpActionResult.</returns>
        [HttpPut]
        public IHttpActionResult Put(WebVehicle webVehicle)
        {
            string response = crudFuction.BizUpdateVehicle(webVehicle.WebVehicleToBizVehicle());

            if (!response.Equals("EXITO"))
                return BadRequest(response);
            else
                return Ok(response);
        }

        /// <summary>
        /// Deletes the specified web vehicle.
        /// </summary>
        /// <param name="webVehicle">The web vehicle.</param>
        /// <returns>IHttpActionResult.</returns>
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
