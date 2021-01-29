using AutoMapper;
using ClinicManagement.Core;
using ClinicManagement.Core.Dto;
using ClinicManagement.Core.Models;
using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;

namespace ClinicManagement.Controllers.Api
{

    [System.Web.Http.Route("api/appointment")]
    public class AppointmentController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppointmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        [System.Web.Http.Route("create-appointment")]
        [System.Web.Http.HttpPost]
        public JsonResult Create(Appointment appointment)
        {
            _unitOfWork.Appointments.Add(appointment);

            return new JsonResult() { Data = "Appointment created!" };

        }
    }
}