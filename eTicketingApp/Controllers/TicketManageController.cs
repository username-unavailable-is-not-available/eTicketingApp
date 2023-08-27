using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
    public class TicketManageController : ApiController
    {
        [HttpGet]
        [Route("api/tickets/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TicketManageService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/tickets/add")]
        public HttpResponseMessage Add(TicketManageDTO newTicket)
        {
            try
            {
                var data = TicketManageService.Add(newTicket);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/tickets/update")]
        public HttpResponseMessage Update(TicketManageDTO updateTicket)
        {
            try
            {
                var data = TicketManageService.Update(updateTicket);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/tickets/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = TicketManageService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}