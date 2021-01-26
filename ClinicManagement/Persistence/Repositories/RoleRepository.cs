using ClinicManagement.Core.Models;
using ClinicManagement.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Persistence.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}