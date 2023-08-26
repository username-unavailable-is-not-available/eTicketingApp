using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
    //[RoutePrefix("api/vehicle")]
    public class VehicleController : ApiController
    {
        [HttpGet]
        [Route("api/vehicle/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = VehicleService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/vehicle/create")]
        public HttpResponseMessage Create(VehicleDTO newVehicle)
        {
            try
            {
                var createdVehicle = VehicleService.Create(newVehicle);
                return Request.CreateResponse(HttpStatusCode.OK, createdVehicle);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/vehicle/update")]
        public HttpResponseMessage Update(VehicleDTO updateVehicle)
        {
            try
            {
                var updatedVehicle = VehicleService.Update(updateVehicle);
                return Request.CreateResponse(HttpStatusCode.OK, updatedVehicle);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/vehicle/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var deleteVehicle = VehicleService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, deleteVehicle);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}
