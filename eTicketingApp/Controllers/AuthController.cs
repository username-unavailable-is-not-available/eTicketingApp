using BLL.DTOs;
using BLL.Services;
using eTicketingApp.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketingApp.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/user/create")]
        public HttpResponseMessage Create(UserDTO newUser)
        {
            try
            {
                var createdUser = UserService.Create(newUser);
                return Request.CreateResponse(HttpStatusCode.OK, createdUser);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel data)
        {
            var token = AuthService.Login(data.Username, data.Password);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { Msg = "User not found" });
            }
        }
    }
}
