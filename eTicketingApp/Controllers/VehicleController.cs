using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
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
    }
}
