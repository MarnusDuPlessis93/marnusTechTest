using ClinicManagement.Core.Models;
using ClinicManagement.Core.Repositories;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationUserManager _userManger;
        public UserRepository(ApplicationUserManager userManger)
        {
            _userManger = userManger;
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? Request.GetOwinContext().GetUserManager<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        public void Add(ApplicationUser applicationUser, List<int> roleIds)
        {
            
        }

    }
}