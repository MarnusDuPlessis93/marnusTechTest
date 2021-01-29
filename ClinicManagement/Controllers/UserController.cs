using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ClinicManagement.Core;
using ClinicManagement.Core.Models;
using ClinicManagement.Core.ViewModel;
using Microsoft.AspNet.Identity.EntityFramework;

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
            var model = new UserViewModel();
            var roles = _unitOfWork.Roles.GetRoles();

            foreach (var role in roles)
            {
                var selectListItem = new SelectListItem
                {
                    Value = role.Id,
                    Text = role.Name
                };
                model.RolesList.Add(selectListItem);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = userViewModel.Username,
                Email = userViewModel.Email,
                PasswordHash = System.Web.Security.Membership.GeneratePassword(8, 4)
            };
            var roleIds = new List<string>();
            var roles = _unitOfWork.Roles.GetRoles();

            if (userViewModel.IsAdmin)
            {
                roleIds.Add(roles.Where(o => o.Name == "Administrator").First().Id);
            }
            if (userViewModel.IsDoctor)
            {
                roleIds.Add(roles.Where(o => o.Name == "Doctor").First().Id);
            }

            var createNewUser = _unitOfWork.Users.CreateUser(applicationUser, roleIds);

            return RedirectToAction("Create");
        }
    }
}