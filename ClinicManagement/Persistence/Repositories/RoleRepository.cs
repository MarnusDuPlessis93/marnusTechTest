using ClinicManagement.Core.Models;
using ClinicManagement.Core.Repositories;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ClinicManagement.Persistence.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager _userManager;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetRoles()
        {
            var roles = new UserManager("a", "a");
            var return roles.GetRoles
        }
    }
}