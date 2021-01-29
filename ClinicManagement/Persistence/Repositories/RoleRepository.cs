using ClinicManagement.Core.Models;
using ClinicManagement.Core.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace ClinicManagement.Persistence.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public List<IdentityRole> GetRoles()
        {
            var roleStore = new RoleStore<IdentityRole>(_context);
            var roleMngr = new RoleManager<IdentityRole>(roleStore);

            return roleMngr.Roles.ToList();


        }
    }
}