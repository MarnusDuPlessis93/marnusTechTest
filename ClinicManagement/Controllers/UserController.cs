using System.Linq;
using System.Web.Mvc;
using ClinicManagement.Core;
using ClinicManagement.Core.Models;
using ClinicManagement.Core.ViewModel;

namespace ClinicManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: User
        public ActionResult Create()
        {
            //var model = new UserViewModel
            //{
            //    RolesList = _unitOfWork.

            //}
            return View();
        }
    }
}