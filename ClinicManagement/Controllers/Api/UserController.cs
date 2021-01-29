using AutoMapper;
using ClinicManagement.Core;
using ClinicManagement.Core.Dto;
using ClinicManagement.Core.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ClinicManagement.Controllers.Api
{
    [System.Web.Http.Route("api/user")]
    public class UserController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        [System.Web.Http.Route("get-active-users")]
        public JsonResult GetActiveUsers()
        {
            var activeUsers = _unitOfWork.Users.GetUsers().Where(o => o.IsActive == true).ToList();


            return new JsonResult() { Data = activeUsers };

        }
    }

}