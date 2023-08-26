using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
    public class BusController : ApiController
    {
        [HttpGet]
        [Route("api/bus/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = BusService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/bus/create")]
        public HttpResponseMessage Create(BusDTO newBus)
        {
            try
            {
                var createdBus = BusService.Create(newBus);
                return Request.CreateResponse(HttpStatusCode.OK, createdBus);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/bus/update")]
        public HttpResponseMessage Update(BusDTO updateBus)
        {
            try
            {
                var updatedBus = BusService.Update(updateBus);
                return Request.CreateResponse(HttpStatusCode.OK, updatedBus);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/bus/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var deleteBus = BusService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, deleteBus);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
