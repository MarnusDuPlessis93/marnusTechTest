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
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(ApplicationUser applicationUser, List<int> roleIds)
        {
            var user = _context.Users.Add(applicationUser);
            
            _context.SaveChanges();
        }

    }
}