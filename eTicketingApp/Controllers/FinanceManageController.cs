using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
    public class FinanceManageController : ApiController
    {
        [HttpGet]
        [Route("api/finances/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = FinanceManageService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/finances/add")]
        public HttpResponseMessage Add(FinanceManageDTO newSalary)
        {
            try
            {
                var data = FinanceManageService.Add(newSalary);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/finances/update")]
        public HttpResponseMessage Update(FinanceManageDTO updateSalary)
        {
            try
            {
                var data = FinanceManageService.Update(updateSalary);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/finances/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = FinanceManageService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}