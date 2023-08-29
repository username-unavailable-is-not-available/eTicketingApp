using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eTicketingApp.Controllers
{
    public class TrainController : ApiController
    {
        [HttpGet]
        [Route("api/Train/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TrainService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/Train/create")]
        public HttpResponseMessage Create(TrainDTO newTrain)
        {
            try
            {
                var createdTrain = TrainService.Create(newTrain);
                return Request.CreateResponse(HttpStatusCode.OK, createdTrain);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/Train/update")]
        public HttpResponseMessage Update(TrainDTO updateTrain)
        {
            try
            {
                var updatedTrain = TrainService.Update(updateTrain);
                return Request.CreateResponse(HttpStatusCode.OK, updatedTrain);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Train/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var deleteTrain = TrainService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, deleteTrain);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
