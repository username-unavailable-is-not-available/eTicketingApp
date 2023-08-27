using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketApp.Controllers
{
    public class EmployeeManageController : ApiController
    {
        [HttpGet]
        [Route("api/employees/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = EmployeeManageService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/employees/add")]
        public HttpResponseMessage Add(EmployeeManageDTO newEmployee)
        {
            try
            {
                var data = EmployeeManageService.Add(newEmployee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/employees/update")]
        public HttpResponseMessage Update(EmployeeManageDTO updateEmployee)
        {
            try
            {
                var data = EmployeeManageService.Update(updateEmployee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/employees/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = EmployeeManageService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}