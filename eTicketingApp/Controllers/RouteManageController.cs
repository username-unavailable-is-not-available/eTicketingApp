using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
    public class RouteManageController : ApiController
    {
        [HttpGet]
        [Route("api/routes/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = RouteManageService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/routes/add")]
        public HttpResponseMessage Add(RouteManageDTO newRoute)
        {
            try
            {
                var data = RouteManageService.Add(newRoute);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/routes/update")]
        public HttpResponseMessage Update(RouteManageDTO updateRoute)
        {
            try
            {
                var data = RouteManageService.Update(updateRoute);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/routes/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = RouteManageService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}