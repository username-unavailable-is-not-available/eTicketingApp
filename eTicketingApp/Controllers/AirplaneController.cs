using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketingApp.Controllers
{
    public class AirplaneController : ApiController
    {
        [HttpGet]
        [Route("api/Airplane/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AirplaneService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/Airplane/create")]
        public HttpResponseMessage Create(AirplaneDTO newAirplane)
        {
            try
            {
                var createdAirplane = AirplaneService.Create(newAirplane);
                return Request.CreateResponse(HttpStatusCode.OK, createdAirplane);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/Airplane/update")]
        public HttpResponseMessage Update(AirplaneDTO updateAirplane)
        {
            try
            {
                var updatedAirplane = AirplaneService.Update(updateAirplane);
                return Request.CreateResponse(HttpStatusCode.OK, updatedAirplane);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Airplane/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var deleteAirplane = AirplaneService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, deleteAirplane);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
